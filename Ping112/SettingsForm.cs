using System;
using System.Windows.Forms;

namespace Ping112
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Services.mre.Reset();
            nudPingTimeout.Value = Convert.ToDecimal(Properties.Settings.Default.PingTimeout);
            nudPingDelay.Value = Convert.ToDecimal(Properties.Settings.Default.PingRetry);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PingTimeout = nudPingTimeout.Value.ToString();
            Properties.Settings.Default.PingRetry = nudPingDelay.Value.ToString();
            Properties.Settings.Default.Save();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Services.mre.Set();
        }
    }
}
