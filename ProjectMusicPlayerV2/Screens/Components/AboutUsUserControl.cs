using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMusicPlayerV2.Screens.Components
{
    public partial class AboutUsUserControl : UserControl
    {
        public AboutUsUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/jingsongtaing"; 

            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/profile.php?id=100093239088732";

            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true }); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "https://x.com/JingSong1602";

            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true }); 
        }
    }
}
