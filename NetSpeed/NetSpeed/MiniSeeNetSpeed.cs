using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeeNetSpeed
{
    public partial class MiniSeeNetSpeed : UserControl
    {
        public MiniSeeNetSpeed()
        {
            InitializeComponent();
        }
        public string upLoadSpeeds { set { value = upLoadSpeed.Text; } }
        public string downLoadSpeeds { set { value = downLoadSpeed.Text; } }
    }
}
