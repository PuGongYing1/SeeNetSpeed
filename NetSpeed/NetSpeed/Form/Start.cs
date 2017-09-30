using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSpeed
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void next_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Color c = Color.FromArgb(80, 0, 0, 0);
            Pen pen = new Pen(c,(float)0.2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(pen, new Point(0, 279), new Point(488, 279));
            g.Dispose();
        }
    }
}
