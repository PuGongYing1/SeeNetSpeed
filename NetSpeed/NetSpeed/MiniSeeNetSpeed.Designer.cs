namespace SeeNetSpeed
{
    partial class MiniSeeNetSpeed
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdown = new System.Windows.Forms.Label();
            this.upLoadSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.downLoadSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SeeNetSpeed.Resource1.tip;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 26);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtdown
            // 
            this.txtdown.AutoSize = true;
            this.txtdown.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtdown.Location = new System.Drawing.Point(12, 12);
            this.txtdown.Name = "txtdown";
            this.txtdown.Size = new System.Drawing.Size(42, 16);
            this.txtdown.TabIndex = 16;
            this.txtdown.Text = "Down:";
            // 
            // upLoadSpeed
            // 
            this.upLoadSpeed.AutoSize = true;
            this.upLoadSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upLoadSpeed.Location = new System.Drawing.Point(52, 0);
            this.upLoadSpeed.Name = "upLoadSpeed";
            this.upLoadSpeed.Size = new System.Drawing.Size(29, 16);
            this.upLoadSpeed.TabIndex = 17;
            this.upLoadSpeed.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Up:";
            // 
            // downLoadSpeed
            // 
            this.downLoadSpeed.AutoSize = true;
            this.downLoadSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.downLoadSpeed.Location = new System.Drawing.Point(52, 12);
            this.downLoadSpeed.Name = "downLoadSpeed";
            this.downLoadSpeed.Size = new System.Drawing.Size(29, 16);
            this.downLoadSpeed.TabIndex = 19;
            this.downLoadSpeed.Text = "0.00";
            // 
            // MiniSeeNetSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.upLoadSpeed);
            this.Controls.Add(this.downLoadSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdown);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MiniSeeNetSpeed";
            this.Size = new System.Drawing.Size(132, 27);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtdown;
        private System.Windows.Forms.Label upLoadSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label downLoadSpeed;
    }
}
