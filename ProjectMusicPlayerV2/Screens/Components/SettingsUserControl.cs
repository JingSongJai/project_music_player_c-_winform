using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMusicPlayerV2.Screens.Components
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {
            //colorPicker1.Value = Properties.Settings.Default.BackColor;
            //colorPicker2.Value = Properties.Settings.Default.ForeColor;
            //input1.Text = Properties.Settings.Default.Title;
            //checkbox1.Checked = Properties.Settings.Default.isHide; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Program.mForm.windowBar1.BackColor = colorPicker1.Value;
            //Program.mForm.button1.DefaultBack = colorPicker1.Value;
            //Program.mForm.button2.DefaultBack = colorPicker1.Value;
            //Program.mForm.windowBar1.ForeColor = colorPicker2.Value;
            //Program.mForm.button1.ForeColor = colorPicker2.Value;
            //Program.mForm.button2.ForeColor = colorPicker2.Value;
            //Program.mForm.windowBar1.Text = input1.Text; 
            //Properties.Settings.Default.BackColor = colorPicker1.Value;
            //Properties.Settings.Default.ForeColor = colorPicker2.Value;
            //Properties.Settings.Default.Title = input1.Text;
            //Properties.Settings.Default.isHide = checkbox1.Checked;
            //Properties.Settings.Default.Save(); 
        }
    }
}
