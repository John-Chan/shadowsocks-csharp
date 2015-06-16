namespace Shadowsocks.View
{
    partial class StatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Sent = new System.Windows.Forms.Label();
            this.lbl_Recv = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_SentBps = new System.Windows.Forms.Label();
            this.lbl_RecvBps = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Version.Location = new System.Drawing.Point(3, 0);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(75, 12);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "SS Version";
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Server.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Server.Location = new System.Drawing.Point(3, 25);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(47, 12);
            this.lbl_Server.TabIndex = 1;
            this.lbl_Server.Text = "Server";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Port.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Port.Location = new System.Drawing.Point(3, 50);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(96, 12);
            this.lbl_Port.TabIndex = 2;
            this.lbl_Port.Text = "Running  port";
            // 
            // lbl_Sent
            // 
            this.lbl_Sent.AutoSize = true;
            this.lbl_Sent.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Sent.Location = new System.Drawing.Point(3, 75);
            this.lbl_Sent.Name = "lbl_Sent";
            this.lbl_Sent.Size = new System.Drawing.Size(65, 12);
            this.lbl_Sent.TabIndex = 3;
            this.lbl_Sent.Text = "total sent";
            // 
            // lbl_Recv
            // 
            this.lbl_Recv.AutoSize = true;
            this.lbl_Recv.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_Recv.Location = new System.Drawing.Point(3, 100);
            this.lbl_Recv.Name = "lbl_Recv";
            this.lbl_Recv.Size = new System.Drawing.Size(65, 12);
            this.lbl_Recv.TabIndex = 4;
            this.lbl_Recv.Text = "total recv";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Version, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Server, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Sent, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Port, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Recv, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_SentBps, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_RecvBps, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 243);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lbl_SentBps
            // 
            this.lbl_SentBps.AutoSize = true;
            this.lbl_SentBps.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_SentBps.Location = new System.Drawing.Point(3, 125);
            this.lbl_SentBps.Name = "lbl_SentBps";
            this.lbl_SentBps.Size = new System.Drawing.Size(71, 12);
            this.lbl_SentBps.TabIndex = 5;
            this.lbl_SentBps.Text = "lbl_SentBps";
            // 
            // lbl_RecvBps
            // 
            this.lbl_RecvBps.AutoSize = true;
            this.lbl_RecvBps.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_RecvBps.Location = new System.Drawing.Point(3, 150);
            this.lbl_RecvBps.Name = "lbl_RecvBps";
            this.lbl_RecvBps.Size = new System.Drawing.Size(71, 12);
            this.lbl_RecvBps.TabIndex = 6;
            this.lbl_RecvBps.Text = "lbl_RecvBps";
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 267);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "StatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Sent;
        private System.Windows.Forms.Label lbl_Recv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_SentBps;
        private System.Windows.Forms.Label lbl_RecvBps;
    }
}