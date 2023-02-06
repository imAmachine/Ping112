using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Ping112
{
    public partial class MainForm : Form
    {
        Thread pingThr = null;

        private List<KeyValuePair<bool, string>> _filters = new List<KeyValuePair<bool, string>>();

        public MainForm()
        {
            InitializeComponent();
            tableLayoutPanel1.ColumnStyles[1].Width = 40;
        }

        /// <summary>
        /// Обработчик кнопка импорта таблицы CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiSettingsImport_Click(object sender, EventArgs e)
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
                    dgvListDds.DataSource = null;
                    dgvListDds.DataSource = ListDds.AllDds;

                    pingThr = new Thread(Services.PingThread);
                    pingThr.IsBackground = true;
                    pingThr.Start(new object[] { dgvListDds });
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
        private void TsmiSettingsParametersPing_Click(object sender, EventArgs e)
        {
            using (SettingsForm sf = new SettingsForm())
            {
                sf.ShowDialog();
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

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dgvListDds.ClearSelection();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DDS dds = (sender as DataGridView).SelectedCells[0].OwningRow.DataBoundItem as DDS;

            using (DoubleClickForm dcf = new DoubleClickForm(dds))
            {
                dcf.ShowDialog();
            }
        }

        private void DgvListDds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListDds.ClearSelection();
        }

        private void DgvListDds_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex != 0)
            {
                e.CellStyle.ForeColor = e.CellStyle.BackColor;
                e.CellStyle.SelectionForeColor = e.CellStyle.SelectionBackColor;
            }
        }
    }
}
