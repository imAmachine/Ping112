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
                List<DataGridViewRow> gridRows = dataGridView1.Rows.Cast<DataGridViewRow>().ToList();
                while (true)
                {
                    if (ListDds.AllDds.Count > 0)
                    {
                        ListDds.AllDds.AsParallel().ForAll(dds =>
                        {
                            DataGridViewRow cur = gridRows.FirstOrDefault(r => r.DataBoundItem == dds);
                            if (cur != null)
                            {
                                List<DataGridViewCell> cells = cur.Cells.Cast<DataGridViewCell>().Skip(1).Take(4).ToList();
                                cells.AsParallel().ForAll(cell =>
                                {
                                    if (cell.Value != null)
                                    {
                                        string[] ip = cell.Value.ToString()
                                                        .Split(',')
                                                        .Select(c => c.Trim())
                                                        .ToArray();
                                        if (ip.Length > 1)
                                        {
                                            bool[] replyes = Services.PingDds(ip);
                                            List<bool> notConnected = replyes.Where(r => r == false).ToList();

                                            if (notConnected.Count == 0)
                                                cell.Style.BackColor = Color.Green;
                                            else if (notConnected.Count < replyes.Length)
                                                cell.Style.BackColor = Color.Yellow;
                                            else
                                                cell.Style.BackColor = Color.Red;
                                        }
                                        else
                                            cell.Style.BackColor = Services.PingDds(cell.Value.ToString()) ? Color.Green : Color.Red;
                                    }
                                });
                            }
                        });
                    }
                    Thread.Sleep(Properties.Settings.Default.PingRetry);
                }
            }
            catch { }
        }

        private void импортТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files|*.csv";
                ofd.Title = "Выберите CSV файл";

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
