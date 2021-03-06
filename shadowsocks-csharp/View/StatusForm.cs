﻿using System;
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
        private Int64 _lastSent = 0;
        private Int64 _lastRecv = 0;
        public StatusForm(Configuration config, PerfCounter perfCounter)
        {
            InitializeComponent();
            _config = config;
            _perfCounter = perfCounter;
            updateInfo();

            lbl_SentBps.Text = String.Format(
                I18N.GetString("Upload Speed : {0}"),
                PerfCounter.formatByteString(0)
                );
            lbl_RecvBps.Text = String.Format(
                I18N.GetString("Download Speed : {0}"),
                PerfCounter.formatByteString(0)
                );
        }

        private void updateInfo()
        {
            lbl_Version.Text = I18N.GetString("Shadowsocks") + " " + UpdateChecker.Version;
            lbl_Server.Text = String.Format(I18N.GetString("Current Server: {0}"), _config.GetCurrentServer().FriendlyName());
            lbl_Port.Text = String.Format(I18N.GetString("Running: Port {0}"), _config.localPort);

            lbl_Sent.Text = String.Format(
                I18N.GetString("Total Upload Bytes: {0}"),
                PerfCounter.formatByteString(_perfCounter.getSentBytes().getVal())
                );
            lbl_Recv.Text = String.Format(
                I18N.GetString("Total Download Bytes: {0}"),
                PerfCounter.formatByteString(_perfCounter.getReceivedBytes().getVal())
                );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateInfo();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Int64 currentSent = _perfCounter.getSentBytes().getVal();
            Int64 currentRecv = _perfCounter.getReceivedBytes().getVal();
            Int64 bpsSent = currentSent - _lastSent;
            Int64 bpsRecv = currentRecv - _lastRecv;

            lbl_SentBps.Text = String.Format(
                I18N.GetString("Upload Speed : {0}"),
                PerfCounter.formatByteString(bpsSent)
                );
            lbl_RecvBps.Text = String.Format(
                I18N.GetString("Download Speed : {0}"),
                PerfCounter.formatByteString(bpsRecv)
                );

            _lastSent = currentSent;
            _lastRecv = currentRecv;
        }
    }
}
