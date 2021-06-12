using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping112
{
    public partial class MainForm : Form
    {
        Thread pingThr = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void PingTask()
        {
            try
            {
                //  Получение строк таблицы DataGridView
                List<DataGridViewRow> gridRows = dataGridView1.Rows.Cast<DataGridViewRow>().ToList();

                //  Бесконечный цикл обработки запросов Ping
                while (true)
                {
                    //  Параллельная обработка всех строк DataGridView
                    gridRows.AsParallel().ForAll(currRow =>
                    {
                        //  Получение ячеек текущей строки, содержащих ip адреса
                        List<DataGridViewCell> cells = currRow.Cells.Cast<DataGridViewCell>().Skip(1).Take(4).ToList();

                        //  параллельная обработка каждой ячейки текущей строки
                        cells.AsParallel().ForAll(cell =>
                        {
                            //  получение списка ip адресов из ячейки
                            string[] ip = cell.Value.ToString()
                                            .Split(',')
                                            .Select(c => c.Trim())
                                            .ToArray();

                            //  Получение ответов на запрос Ping для каждого ip адреса по порядку
                            bool[] replyes = Services.PingDds(ip);                              //  Все ответы
                            List<bool> notConnected = replyes.Where(r => r == false).ToList();  //  ответы с отключенными ip адресами

                            /*  
                             *  1. Если все ip в сети - отметить ячейку зелёным цветом
                             *  2. Если часть ip адресов не в сети - пометить ячейку жёлтым цветом
                             *  3. Если все ip адреса не в сети - пометить ячейку красным цветом
                            */
                            if (notConnected.Count == 0)                    //  1
                                cell.Style.BackColor = Color.Green;
                            else if (notConnected.Count < replyes.Length)   //  2
                                cell.Style.BackColor = Color.Yellow;
                            else                                            //  3
                                cell.Style.BackColor = Color.Red;
                        });
                    });
                    Thread.Sleep(Properties.Settings.Default.PingRetry);    //  Пауза перед следующим "прозвоном" ip адресов
                }
            }
            catch { }
        }

        /// <summary>
        /// Обработчик кнопка импорта таблицы CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void импортТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Вызов окна выбора файла
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files|*.csv";
                ofd.Title = "Выберите CSV файл";

                // Если подключение выбранного файла прошло успешно, текущий путь к файлу CSV будет сохранён в память приложения
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.CsvPath = ofd.FileName;
                    if (InitDdsList())
                        Properties.Settings.Default.Save();
                    else
                        Properties.Settings.Default.Reset();
                }
            }
        }

        /// <summary>
        /// Метод для инициализации импортируемой таблицы CSV, производит запуск потока для "прозвона" ip адресов по таблице
        /// </summary>
        /// <returns>Возвращает статус иициализации импортируемой таблицы</returns>
        private bool InitDdsList()
        {
            if (File.Exists(Properties.Settings.Default.CsvPath))
            {
                Services.ReadCsv(Properties.Settings.Default.CsvPath);
                if (ListDds.AllDds != null && ListDds.AllDds.Count > 0)
                {
                    if (pingThr != null && pingThr.IsAlive)
                        pingThr.Abort();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ListDds.AllDds;

                    pingThr = new Thread(new ThreadStart(PingTask));
                    pingThr.Start();
                    return true;
                }
                else if (ListDds.AllDds.Count <= 0)
                {
                    MessageBox.Show("Коллекция ДДС пуста");
                    return false;
                }
                else
                {
                    MessageBox.Show("Неизвестная ошибка");
                    return false;
                }
            }
            else
                return false;
        }
        private void параметрыPingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            InitDdsList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pingThr.Abort();
        }
    }
}
