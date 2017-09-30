using SeeNetSpeed;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace NetSpeed
{
    public partial class NetSpeed : Form
    {
        public NetSpeed()
        {
            InitializeComponent();
            InitNetworkInterface();
        }

        #region 获取数据
        public static NetworkInterface[] nicArr;  //网卡集合
        public int unit = 1;
        public string speedUnit = " Byte/s";
        public int accuracy = 2;
        private void InitNetworkInterface()
        {
            nicArr = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < nicArr.Length; i++)
                cboNetworkInterface.Items.Add(nicArr[i].Name);
            cboNetworkInterface.SelectedIndex = 0;
        }
        string up, down;
        private void timer1_Tick(object sender, EventArgs e)
        {
            NetworkInterface nic = nicArr[cboNetworkInterface.SelectedIndex];
            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

            double bytesSentSpeed = Math.Round(((double)(interfaceStats.BytesSent -
                double.Parse(txtbBytesSent.Text)) / unit), accuracy);
            double bytesReceivedSpeed = Math.Round(((double)(interfaceStats.BytesReceived -
                double.Parse(txtbBytesReceived.Text)) / unit), accuracy);

            up = bytesSentSpeed.ToString() + speedUnit;
            txtbSentSpeed.Text = up;
            down = bytesReceivedSpeed.ToString() + speedUnit;
            txtbReceivedSpeed.Text = down;

            txtbInterfaceType.Text = nic.NetworkInterfaceType.ToString();
            txtbBytesReceived.Text = interfaceStats.BytesReceived.ToString();
            txtbBytesSent.Text = interfaceStats.BytesSent.ToString();
        }
        #endregion

        #region 参数修改
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboUnit.SelectedItem.ToString())
            {
                case "Byte/s": unit = 1; speedUnit = " Byte/s"; break;
                case "KB/s": unit = 1024; speedUnit = " KB/s"; break;
                case "MB/s": unit = 1024 * 1024; speedUnit = " MB/s"; break;
            }
        }

        private void cboAccuracy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboAccuracy.SelectedItem.ToString())
            {
                case "2位": accuracy = 2; break;
                case "3位": accuracy = 3; break;
                case "4位": accuracy = 4; break;
                case "5位": accuracy = 5; break;
            }
        }

        #endregion

    }

}
