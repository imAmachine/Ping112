using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ping112
{
    public partial class DoubleClickForm : Form
    {
        private DDS _dds = null;
        Thread[] pingThr = new Thread[4];
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

                dgvPcs.DataSource = value.IpPcs.Split(',').Select(s => new { pcs = s }).ToList();
                dgvPhones.DataSource = value.IpPhones.Split(',').Select(s => new { phones = s }).ToList();
                dgvRtks.DataSource = value.IpRTK.Split(',').Select(s => new { rtks = s }).ToList();
                dgvVipNets.DataSource = value.IpVipNet.Split(',').Select(s => new { vipnets = s }).ToList();
                
                dgvPcs.Columns[0].HeaderText = "Компьютеры";
                dgvPhones.Columns[0].HeaderText = "Телефоны";
                dgvRtks.Columns[0].HeaderText = "Коммутаторы";
                dgvVipNets.Columns[0].HeaderText = "VipNet";
            }
        }
        public DoubleClickForm(DDS dds)
        {
            InitializeComponent();
            this.dds = dds;
        }

        private void DoubleClickForm_Load(object sender, EventArgs e)
        {
            dgvPcs.ClearSelection();
            dgvPhones.ClearSelection();
            dgvRtks.ClearSelection();
            dgvVipNets.ClearSelection();

            pingThr[0] = new Thread(Services.PingTask);
            pingThr[0].Start(dgvVipNets);

            pingThr[1] = new Thread(Services.PingTask);
            pingThr[1].Start(dgvRtks);

            pingThr[2] = new Thread(Services.PingTask);
            pingThr[2].Start(dgvPcs);

            pingThr[3] = new Thread(Services.PingTask);
            pingThr[3].Start(dgvPhones);
        }

        private void DoubleClickForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread thr in pingThr)
                thr.Abort();
        }
    }
}
