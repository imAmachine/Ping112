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

                //  Если подключение выбранного файла прошло успешно, текущий путь к файлу CSV будет сохранён в память приложения
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

                    pingThr = new Thread(Services.PingTask);
                    pingThr.Start(dataGridView1);
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
            using (SettingsForm sf = new SettingsForm())
            {
                pingThr.Abort();
                sf.ShowDialog();

                pingThr = new Thread(Services.PingTask);
                pingThr.Start(dataGridView1);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitDdsList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pingThr.Abort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pingThr.Abort();

            if (textBox1.Text.Length > 0)
            {
                List<DDS> list = ListDds.AllDds.Where(dds => dds.Name.ToLower().Contains(textBox1.Text.Trim())).ToList();
                dataGridView1.DataSource = list;
            }
            else
                dataGridView1.DataSource = ListDds.AllDds;
            dataGridView1.ClearSelection();

            pingThr = new Thread(Services.PingTask);
            pingThr.Start(dataGridView1);
        }

        private void MainForm_ClientSizeChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).SelectedCells[0].OwningRow;

            DDS dds = row.DataBoundItem as DDS;
            using (DoubleClickForm dcf = new DoubleClickForm(dds))
            {
                pingThr.Abort();
                dcf.ShowDialog();

                pingThr = new Thread(Services.PingTask);
                pingThr.Start(dataGridView1);
            }
        }
    }
}
