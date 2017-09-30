using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SeeNetSpeed
{
    class Configure
    {
        public string unit= "1", accuracy= "1", networkInterfaceselect = "0";
        public Configure()
        {
            if (File.Exists("NetSpeed.date"))
            {
                StreamReader reader = new StreamReader("NetSpeed.date");
                string[] txt = reader.ReadToEnd().Split('-');
                if (txt.Length >= 3)
                {
                    unit = txt[0];
                    accuracy = txt[1];
                    networkInterfaceselect = txt[2];
                    reader.Close();
                }


                NetworkInterface[] nicArr = NetworkInterface.GetAllNetworkInterfaces();
                for(int i = 0;i< MiniSpeed.nicArrName.Count; i++)
                {
                    if (networkInterfaceselect == MiniSpeed.nicArrName[i])
                    {
                        networkInterfaceselect = i.ToString();
                        break;
                    }
                }

                // 纠错机制
                if (unit != "1048576" && unit != "1024" && unit != "1")
                    unit = "1";

                if (accuracy != "3" && accuracy != "2" && accuracy != "1" && accuracy != "4" && accuracy != "5")
                    accuracy = "1";

                try
                {
                    if (Int32.Parse(networkInterfaceselect) < 0 ||
                        Int32.Parse(networkInterfaceselect) > MiniSpeed.nicArrName.Count - 1
                        )
                    {
                        networkInterfaceselect = "0";
                    }
                }
                catch (System.FormatException)
                {
                    networkInterfaceselect = "0";
                }


            }

        }

    }
}
