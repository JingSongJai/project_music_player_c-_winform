using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMusicPlayerV2.Screens
{
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void checkbox1_CheckedChanged(object sender, bool value)
        {
            Properties.Settings.Default.DontShow = checkbox1.Checked;
            Properties.Settings.Default.Save(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://fonts.google.com/specimen/Poppins?query=poppins";

            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }
    }
}
