using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeeNetSpeed
{
    public partial class MiniSpeed : Form
    {
        public MiniSpeed()
        {
            InitializeComponent();

            InitNetworkInterface();

        }

        public static NetworkInterface[] nicArr;  //网卡集合
        public int unit = 1;
        public string speedUnit = " Byte/s";
        public int accuracy =1, networkInterfaceselect = 0;
        public static List<string> nicArrName = new List<string>();
        string nicArrNameSelect;
        string BytesSent, BytesReceived;

        #region 获取数据

        private void InitNetworkInterface()
        {
            nicArr = NetworkInterface.GetAllNetworkInterfaces();
            nicArrNameSelect = nicArr[0].Name;

            for (int i = 0; i < nicArr.Length; i++)
            {
                nicArrName.Add(nicArr[i].Name);
                ToolStripItem ts_1 = new ToolStripMenuItem(nicArr[i].Name);
                网络接口ToolStripMenuItem.DropDownItems.Add(ts_1);
                ts_1.Click += new EventHandler(ts_1_Click);
                if (i == 0)
                    (ts_1 as ToolStripMenuItem).Checked = true;
            }
        }

        private void ts_1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem nicArr = sender as ToolStripMenuItem;
            nicArrNameSelect = nicArr.Text;
            for (int i = 0;i < nicArrName.Count; i++)
            {
                if (nicArr.Text == nicArrName[i])
                    networkInterfaceselect = i;
            }
            ChangeChecked(sender, 网络接口ToolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NetworkInterface nic = nicArr[networkInterfaceselect];
            IPInterfaceStatistics  interfaceStats = nic.GetIPStatistics();

            double bytesSentSpeed = Math.Round(((double)(interfaceStats.BytesSent -
                double.Parse(BytesSent)) / unit), accuracy);
            double bytesReceivedSpeed = Math.Round(((double)(interfaceStats.BytesReceived -
                double.Parse(BytesReceived)) / unit), accuracy);

            upLoadSpeed.Text = bytesSentSpeed.ToString() + speedUnit;
            downLoadSpeed.Text = bytesReceivedSpeed.ToString() + speedUnit;

            BytesReceived = interfaceStats.BytesReceived.ToString();
            BytesSent = interfaceStats.BytesSent.ToString();

            int x = 54 + upLoadSpeed.Width;
            int y = 54 + downLoadSpeed.Width;
            int max = (x > y) ? x : y;
            this.Width = max;

        }
        #endregion

        #region 参数设置

        private void toolStripMenuItemByte_Click(object sender, EventArgs e)
        {
            unit = 1;
            speedUnit = " Byte/s";
            ChangeChecked(sender, 单位toolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);
        }

        private void toolStripMenuItemKb_Click(object sender, EventArgs e)
        {
            unit = 1024;
            speedUnit = " KB/s";
            ChangeChecked(sender, 单位toolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);
        }

        private void toolStripMenuItemMb_Click(object sender, EventArgs e)
        {
            unit = 1048576;
            speedUnit = " MB/s";
            ChangeChecked(sender, 单位toolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);
        }


        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            accuracy = 1;
            ChangeChecked(sender, 精度toolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            accuracy = 2;
            ChangeChecked(sender, 精度toolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            accuracy = 3;
            ChangeChecked(sender, 精度toolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            accuracy = 4;
            ChangeChecked(sender, 精度toolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            accuracy = 5;
            ChangeChecked(sender, 精度toolStripMenuItem.DropDownItems);
            WriteParam(unit, accuracy, nicArrNameSelect);
        }
        #endregion

        #region 位置设置
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        int y;


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Point p = new Point(mouseSet.X, y);
                Location = p;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        public Point getCornerLocation()
        {
            int xPos = 0, yPos = 0;

            if ((Screen.PrimaryScreen.Bounds.Width == Screen.PrimaryScreen.WorkingArea.Width) &&
            (Screen.PrimaryScreen.WorkingArea.Y == 0))
            {
                //taskbar bottom
                xPos = Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width;
                yPos = Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height;
            }
            else if ((Screen.PrimaryScreen.Bounds.Height == Screen.PrimaryScreen.WorkingArea.Height) &&
            (Screen.PrimaryScreen.WorkingArea.X == 0))
            {
                //taskbar right
                xPos = Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width;
                yPos = Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height;
            }
            else if ((Screen.PrimaryScreen.Bounds.Width == Screen.PrimaryScreen.WorkingArea.Width) &&
            (Screen.PrimaryScreen.WorkingArea.Y > 0))
            {
                //taskbar up
                xPos = Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width;
                yPos = Screen.PrimaryScreen.WorkingArea.Y;
            }
            else if ((Screen.PrimaryScreen.Bounds.Height == Screen.PrimaryScreen.WorkingArea.Height) &&
            (Screen.PrimaryScreen.WorkingArea.X > 0))
            {
                //taskbar left
                xPos = Screen.PrimaryScreen.WorkingArea.X;
                yPos = Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height;
            }
            y = yPos;
            return new Point(xPos, yPos);
        }

        #endregion


        public void ChangeChecked(object sender, ToolStripItemCollection items)
        {
            foreach (ToolStripItem c in items)
                (c as ToolStripMenuItem).Checked = false;

            if(sender is ToolStripMenuItem)
                (sender as ToolStripMenuItem).Checked = true;
        }

        public void WriteParam(int unit,int accuracy,string networkInterfaceselect)
        {
            string p = unit.ToString() + "-" + accuracy.ToString() + "-" + networkInterfaceselect + "-";

            StreamWriter wri = new StreamWriter("NetSpeed.date");
            wri.WriteLine(p);
            wri.Close();
        }

        private void MiniSpeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {

                case CloseReason.WindowsShutDown:
                    notifyIcon1.Dispose();
                    System.Environment.Exit(0);
                    break;
                default:
                    break;

            }
        }
        private void MiniSpeed_Load(object sender, EventArgs e)
        {
            this.Location = getCornerLocation();

            Configure cfg = new Configure();
            unit = Int32.Parse(cfg.unit);
            accuracy = Int32.Parse(cfg.accuracy);
            networkInterfaceselect = Int32.Parse(cfg.networkInterfaceselect);

            int unitIndex;
            if (unit == 1048576)
            {
                speedUnit = " MB/s";
                unitIndex = 2;
            }
            else if (unit == 1024)
            {
                speedUnit = " KB/s";
                unitIndex = 1;
            }
            else
            {
                speedUnit = " Byte/s";
                unitIndex = 0;
            }

            ChangeChecked(单位toolStripMenuItem.DropDownItems[unitIndex], 单位toolStripMenuItem.DropDownItems);
            ChangeChecked(精度toolStripMenuItem.DropDownItems[accuracy-1], 精度toolStripMenuItem.DropDownItems);
            ChangeChecked(网络接口ToolStripMenuItem.DropDownItems[networkInterfaceselect],
                网络接口ToolStripMenuItem.DropDownItems);

            NetworkInterface nic = nicArr[networkInterfaceselect];
            IPInterfaceStatistics interfaceStats = nic.GetIPStatistics();


            BytesReceived = interfaceStats.BytesReceived.ToString();
            BytesSent = interfaceStats.BytesSent.ToString();

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            System.Environment.Exit(0);
        }



    }
}
