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
        private bool _isFiltering = true;
        private bool IsFiltering
        {
            get
            {
                return _isFiltering;
            }
            set
            {
                _isFiltering = value;
                Services.FilterDgvCollection(dgvListDds, tb_Search.Text.Trim(), Filters, value);
            }
        }
        private List<KeyValuePair<bool, string>> Filters
        {
            get
            {
                return _filters;
            }
            set
            {
                _filters = value;
                if (IsFiltering)
                    Services.FilterDgvCollection(dgvListDds, tb_Search.Text.Trim(), _filters, IsFiltering);
            }
        }
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

        private void BtnFilterAdd_Click(object sender, EventArgs e)
        {
            string filter = tb_Search.Text.Trim();
            if (filter.Length > 0)
            {
                tb_Search.Clear();
                Filters.RemoveAll(f => f.Key);

                List<KeyValuePair<bool, string>> list = Filters;
                list.Add(new KeyValuePair<bool, string>(true, filter));
                Filters = list;

                tb_PrimaryFilter.Text = filter;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsFiltering = (sender as CheckBox).Checked;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Filters.RemoveAll(f => !f.Key);
        }

        private void BtnSecondaryAdd_Click(object sender, EventArgs e)
        {
            string filter = tb_Search.Text.Trim();
            if (filter.Length > 0)
            {
                if (filter.Length > 0)
                    Filters.RemoveAll(f => !f.Key && f.Value == filter);

                List<KeyValuePair<bool, string>> list = Filters;
                list.Add(new KeyValuePair<bool, string>(false, filter));
                tb_Search.Clear();
                Filters = list;

                lb_SecondaryFilters.DisplayMember = "Value";
                lb_SecondaryFilters.DataSource = Filters.Where(f => f.Key == false).ToList();
            }
        }

        private void BtnDeletePrimary_Click(object sender, EventArgs e)
        {
            Filters.RemoveAll(f => f.Key);
            tb_PrimaryFilter.Clear();
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            Services.FilterDgvCollection(dgvListDds, tb_Search.Text.Trim(), Filters, IsFiltering);
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

        private void Btn_ShowClose_Click(object sender, EventArgs e)
        {
            dgvListDds.Refresh();
            if (tableLayoutPanel1.ColumnStyles[1].Width == 40)
            {
                btn_ShowClose.Text = ">>";
                tableLayoutPanel1.ColumnStyles[1].Width = 250;
            }
            else
            {
                btn_ShowClose.Text = "<<";
                tableLayoutPanel1.ColumnStyles[1].Width = 40;
            }
        }

        private void Btn_DelSelected_Click(object sender, EventArgs e)
        {
            if (lb_SecondaryFilters.SelectedItems.Count > 0)
            {
                List<KeyValuePair<bool, string>> list = Filters;
                foreach (var fs in lb_SecondaryFilters.SelectedItems)
                    list.Remove((KeyValuePair<bool, string>)fs);
                Filters = list;
                lb_SecondaryFilters.DataSource = null;
                lb_SecondaryFilters.DisplayMember = "Value";
                lb_SecondaryFilters.DataSource = Filters;
            }
        }
    }
}
