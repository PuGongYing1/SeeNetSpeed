using SeeNetSpeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSpeed
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isRuned;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "NetSpeed", out isRuned);
            if (isRuned)
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Start show = new Start(); //使用模式对话框方法显示Log
                show.ShowDialog();//DialogResult就是用来判断是否返回父窗体的
                if (show.DialogResult == DialogResult.OK)
                {
                    Application.Run(new NetSpeed()); //在线程中打开主窗体
                }
                mutex.ReleaseMutex();
            }
            else
            {
                MiniSpeed f = new MiniSpeed();

                f.notifyIcon1.ShowBalloonTip(1000, "", "SeeNetSpeed正在后台运行", ToolTipIcon.Warning);
                f.notifyIcon1.Dispose();
            }


        }
    }
}
