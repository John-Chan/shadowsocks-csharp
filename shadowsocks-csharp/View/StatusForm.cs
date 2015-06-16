using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Shadowsocks.Controller;
using Shadowsocks.Model;

namespace Shadowsocks.View
{
    public partial class StatusForm : Form
    {
        private Configuration _config;
        private PerfCounter _perfCounter;
        public StatusForm(Configuration config, PerfCounter perfCounter)
        {
            InitializeComponent();
            _config = config;
            _perfCounter = perfCounter;
            updateInfo();
        }

        private void updateInfo()
        {
            lbl_Version.Text = I18N.GetString("Shadowsocks") + " " + UpdateChecker.Version;
            lbl_Server.Text = String.Format(I18N.GetString("Current Server: {0}"), _config.GetCurrentServer().FriendlyName());
            lbl_Port.Text = String.Format(I18N.GetString("Running: Port {0}"), _config.localPort);
            lbl_Sent.Text = String.Format(
                I18N.GetString("Sent Bytes: {0}"),
                PerfCounter.formatByteString(_perfCounter.getSentBytes().getVal())
                );
            lbl_Recv.Text = String.Format(
                I18N.GetString("Recv Bytes: {0}"),
                PerfCounter.formatByteString(_perfCounter.getReceivedBytes().getVal())
                );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateInfo();
        }
    }
}
