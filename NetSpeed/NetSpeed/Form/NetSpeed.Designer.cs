namespace NetSpeed
{
    partial class NetSpeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetSpeed));
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.cboAccuracy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbSentSpeed = new System.Windows.Forms.Label();
            this.txtbReceivedSpeed = new System.Windows.Forms.Label();
            this.txtbBytesSent = new System.Windows.Forms.Label();
            this.txtbBytesReceived = new System.Windows.Forms.Label();
            this.cboNetworkInterface = new System.Windows.Forms.ComboBox();
            this.txtbInterfaceType = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cboUnit
            // 
            this.cboUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboUnit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "Byte/s",
            "KB/s",
            "MB/s"});
            this.cboUnit.Location = new System.Drawing.Point(127, 44);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(120, 23);
            this.cboUnit.TabIndex = 38;
            this.cboUnit.Text = "Byte/s";
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // cboAccuracy
            // 
            this.cboAccuracy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAccuracy.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAccuracy.FormattingEnabled = true;
            this.cboAccuracy.Items.AddRange(new object[] {
            "2位",
            "3位",
            "4位",
            "5位"});
            this.cboAccuracy.Location = new System.Drawing.Point(127, 74);
            this.cboAccuracy.Name = "cboAccuracy";
            this.cboAccuracy.Size = new System.Drawing.Size(120, 23);
            this.cboAccuracy.TabIndex = 37;
            this.cboAccuracy.Text = "2位";
            this.cboAccuracy.SelectedIndexChanged += new System.EventHandler(this.cboAccuracy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "精度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "单位";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(12, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "网卡";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "上传速度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "下载速度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(12, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "总上传字节";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(12, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "总下载字节";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(12, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "网卡类型";
            // 
            // txtbSentSpeed
            // 
            this.txtbSentSpeed.AutoSize = true;
            this.txtbSentSpeed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbSentSpeed.Location = new System.Drawing.Point(127, 194);
            this.txtbSentSpeed.Name = "txtbSentSpeed";
            this.txtbSentSpeed.Size = new System.Drawing.Size(19, 21);
            this.txtbSentSpeed.TabIndex = 28;
            this.txtbSentSpeed.Text = "0";
            // 
            // txtbReceivedSpeed
            // 
            this.txtbReceivedSpeed.AutoSize = true;
            this.txtbReceivedSpeed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbReceivedSpeed.Location = new System.Drawing.Point(127, 224);
            this.txtbReceivedSpeed.Name = "txtbReceivedSpeed";
            this.txtbReceivedSpeed.Size = new System.Drawing.Size(19, 21);
            this.txtbReceivedSpeed.TabIndex = 27;
            this.txtbReceivedSpeed.Text = "0";
            // 
            // txtbBytesSent
            // 
            this.txtbBytesSent.AutoSize = true;
            this.txtbBytesSent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbBytesSent.Location = new System.Drawing.Point(127, 134);
            this.txtbBytesSent.Name = "txtbBytesSent";
            this.txtbBytesSent.Size = new System.Drawing.Size(19, 21);
            this.txtbBytesSent.TabIndex = 26;
            this.txtbBytesSent.Text = "0";
            // 
            // txtbBytesReceived
            // 
            this.txtbBytesReceived.AutoSize = true;
            this.txtbBytesReceived.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbBytesReceived.Location = new System.Drawing.Point(127, 164);
            this.txtbBytesReceived.Name = "txtbBytesReceived";
            this.txtbBytesReceived.Size = new System.Drawing.Size(19, 21);
            this.txtbBytesReceived.TabIndex = 25;
            this.txtbBytesReceived.Text = "0";
            // 
            // cboNetworkInterface
            // 
            this.cboNetworkInterface.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboNetworkInterface.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNetworkInterface.FormattingEnabled = true;
            this.cboNetworkInterface.Location = new System.Drawing.Point(127, 14);
            this.cboNetworkInterface.Name = "cboNetworkInterface";
            this.cboNetworkInterface.Size = new System.Drawing.Size(214, 23);
            this.cboNetworkInterface.TabIndex = 24;
            // 
            // txtbInterfaceType
            // 
            this.txtbInterfaceType.AutoSize = true;
            this.txtbInterfaceType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbInterfaceType.Location = new System.Drawing.Point(127, 104);
            this.txtbInterfaceType.Name = "txtbInterfaceType";
            this.txtbInterfaceType.Size = new System.Drawing.Size(19, 21);
            this.txtbInterfaceType.TabIndex = 23;
            this.txtbInterfaceType.Text = "0";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "双击左键打开窗体\r\n\r\n单击右键以查看更多模式";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NetSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 288);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.cboAccuracy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbSentSpeed);
            this.Controls.Add(this.txtbReceivedSpeed);
            this.Controls.Add(this.txtbBytesSent);
            this.Controls.Add(this.txtbBytesReceived);
            this.Controls.Add(this.cboNetworkInterface);
            this.Controls.Add(this.txtbInterfaceType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NetSpeed";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetSpeed";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.ComboBox cboAccuracy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtbSentSpeed;
        private System.Windows.Forms.Label txtbReceivedSpeed;
        private System.Windows.Forms.Label txtbBytesSent;
        private System.Windows.Forms.Label txtbBytesReceived;
        private System.Windows.Forms.ComboBox cboNetworkInterface;
        private System.Windows.Forms.Label txtbInterfaceType;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
    }
}