using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Ping112
{
    public partial class DoubleClickForm : Form
    {
        private DDS _dds = null;
        Thread pingThr;
        public DDS dds
        {
            get
            {
                return _dds;
            }

            set
            {
                _dds = value;
                lbDdsName.Text = value.Name;

                foreach (var i in Controls.OfType<DataGridView>())
                    i.AutoGenerateColumns = false;

                dgv_Pc.DataSource = value.IpPcs.Split(',').Select(s => new { IpPcs = s }).ToList();
                dgv_Phone.DataSource = value.IpPhones.Split(',').Select(s => new { IpPhones = s }).ToList();
                dgv_RTK.DataSource = value.IpRTK.Split(',').Select(s => new { IpRTK = s }).ToList();
                dgvVipNets.DataSource = value.IpVipNet.Split(',').Select(s => new { IpVipNet = s }).ToList();

            }
        }
        public DoubleClickForm(DDS dds)
        {
            InitializeComponent();
            this.dds = dds;
        }

        private void DoubleClickForm_Load(object sender, EventArgs e)
        {
            pingThr = new Thread(Services.PingThread) { IsBackground = true };
            pingThr.Start(Controls.OfType<DataGridView>().ToArray());

            foreach (var i in Controls.OfType<DataGridView>())
                i.ClearSelection();
        }
        private void DoubleClickForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pingThr.Abort();
        }
    }
}
