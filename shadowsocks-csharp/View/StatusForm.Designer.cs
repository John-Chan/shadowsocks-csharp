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
            this.SuspendLayout();
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(19, 13);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(41, 12);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "label1";
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(19, 41);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(41, 12);
            this.lbl_Server.TabIndex = 1;
            this.lbl_Server.Text = "label2";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(19, 68);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(41, 12);
            this.lbl_Port.TabIndex = 2;
            this.lbl_Port.Text = "label3";
            // 
            // lbl_Sent
            // 
            this.lbl_Sent.AutoSize = true;
            this.lbl_Sent.Location = new System.Drawing.Point(19, 93);
            this.lbl_Sent.Name = "lbl_Sent";
            this.lbl_Sent.Size = new System.Drawing.Size(41, 12);
            this.lbl_Sent.TabIndex = 3;
            this.lbl_Sent.Text = "label4";
            // 
            // lbl_Recv
            // 
            this.lbl_Recv.AutoSize = true;
            this.lbl_Recv.Location = new System.Drawing.Point(19, 121);
            this.lbl_Recv.Name = "lbl_Recv";
            this.lbl_Recv.Size = new System.Drawing.Size(41, 12);
            this.lbl_Recv.TabIndex = 4;
            this.lbl_Recv.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 267);
            this.Controls.Add(this.lbl_Recv);
            this.Controls.Add(this.lbl_Sent);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_Server);
            this.Controls.Add(this.lbl_Version);
            this.MaximizeBox = false;
            this.Name = "StatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Sent;
        private System.Windows.Forms.Label lbl_Recv;
        private System.Windows.Forms.Timer timer1;
    }
}