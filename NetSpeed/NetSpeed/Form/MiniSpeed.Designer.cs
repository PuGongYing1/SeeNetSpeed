namespace SeeNetSpeed
{
    partial class MiniSpeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniSpeed));
            this.upLoadSpeed = new System.Windows.Forms.Label();
            this.downLoadSpeed = new System.Windows.Forms.Label();
            this.txtUp = new System.Windows.Forms.Label();
            this.txtdown = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.单位toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemByte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMb = new System.Windows.Forms.ToolStripMenuItem();
            this.精度toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.网络接口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // upLoadSpeed
            // 
            this.upLoadSpeed.AutoSize = true;
            this.upLoadSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upLoadSpeed.Location = new System.Drawing.Point(52, 0);
            this.upLoadSpeed.Name = "upLoadSpeed";
            this.upLoadSpeed.Size = new System.Drawing.Size(29, 16);
            this.upLoadSpeed.TabIndex = 22;
            this.upLoadSpeed.Text = "0.00";
            // 
            // downLoadSpeed
            // 
            this.downLoadSpeed.AutoSize = true;
            this.downLoadSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.downLoadSpeed.Location = new System.Drawing.Point(52, 12);
            this.downLoadSpeed.Name = "downLoadSpeed";
            this.downLoadSpeed.Size = new System.Drawing.Size(29, 16);
            this.downLoadSpeed.TabIndex = 24;
            this.downLoadSpeed.Text = "0.00";
            // 
            // txtUp
            // 
            this.txtUp.AutoSize = true;
            this.txtUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUp.Location = new System.Drawing.Point(12, -1);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(26, 16);
            this.txtUp.TabIndex = 23;
            this.txtUp.Text = "Up:";
            // 
            // txtdown
            // 
            this.txtdown.AutoSize = true;
            this.txtdown.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtdown.Location = new System.Drawing.Point(12, 12);
            this.txtdown.Name = "txtdown";
            this.txtdown.Size = new System.Drawing.Size(42, 16);
            this.txtdown.TabIndex = 21;
            this.txtdown.Text = "Down:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = global::SeeNetSpeed.Resource1.tip;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 26);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "单击右键以查看更多模式";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单位toolStripMenuItem,
            this.精度toolStripMenuItem,
            this.网络接口ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.反馈ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 114);
            // 
            // 单位toolStripMenuItem
            // 
            this.单位toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemByte,
            this.toolStripMenuItemKb,
            this.toolStripMenuItemMb});
            this.单位toolStripMenuItem.Name = "单位toolStripMenuItem";
            this.单位toolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.单位toolStripMenuItem.Text = "单位";
            // 
            // toolStripMenuItemByte
            // 
            this.toolStripMenuItemByte.Name = "toolStripMenuItemByte";
            this.toolStripMenuItemByte.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItemByte.Text = "Byte/S";
            this.toolStripMenuItemByte.Click += new System.EventHandler(this.toolStripMenuItemByte_Click);
            // 
            // toolStripMenuItemKb
            // 
            this.toolStripMenuItemKb.Name = "toolStripMenuItemKb";
            this.toolStripMenuItemKb.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItemKb.Text = "KB/S";
            this.toolStripMenuItemKb.Click += new System.EventHandler(this.toolStripMenuItemKb_Click);
            // 
            // toolStripMenuItemMb
            // 
            this.toolStripMenuItemMb.Name = "toolStripMenuItemMb";
            this.toolStripMenuItemMb.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItemMb.Text = "MB/S";
            this.toolStripMenuItemMb.Click += new System.EventHandler(this.toolStripMenuItemMb_Click);
            // 
            // 精度toolStripMenuItem
            // 
            this.精度toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.精度toolStripMenuItem.Name = "精度toolStripMenuItem";
            this.精度toolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.精度toolStripMenuItem.Text = "精度";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.ToolStripMenuItem1.Text = "1位";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(95, 22);
            this.toolStripMenuItem2.Text = "2位";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(95, 22);
            this.toolStripMenuItem3.Text = "3位";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(95, 22);
            this.toolStripMenuItem4.Text = "4位";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(95, 22);
            this.toolStripMenuItem5.Text = "5位";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // 网络接口ToolStripMenuItem
            // 
            this.网络接口ToolStripMenuItem.Name = "网络接口ToolStripMenuItem";
            this.网络接口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.网络接口ToolStripMenuItem.Text = "网络接口";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 反馈ToolStripMenuItem
            // 
            this.反馈ToolStripMenuItem.Name = "反馈ToolStripMenuItem";
            this.反馈ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.反馈ToolStripMenuItem.Text = "反馈";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MiniSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 27);
            this.Controls.Add(this.upLoadSpeed);
            this.Controls.Add(this.downLoadSpeed);
            this.Controls.Add(this.txtUp);
            this.Controls.Add(this.txtdown);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 0);
            this.Name = "MiniSpeed";
            this.ShowInTaskbar = false;
            this.Text = "MiniSpeed";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiniSpeed_FormClosing);
            this.Load += new System.EventHandler(this.MiniSpeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upLoadSpeed;
        private System.Windows.Forms.Label downLoadSpeed;
        private System.Windows.Forms.Label txtUp;
        private System.Windows.Forms.Label txtdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 单位toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemByte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMb;
        private System.Windows.Forms.ToolStripMenuItem 精度toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 网络接口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
    }
}