using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMusicPlayerV2.Screens.Components
{
    public partial class AddPlaylistForm : Form
    {
        public AddPlaylistForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"Playlists\" + input1.Text);
            Program.mForm.panelDisplay.Controls.Clear();
            Program.mForm.panelDisplay.Controls.Add(new PlaylistUserControl() { Dock = DockStyle.Fill }); 
            this.Close(); 
        }
    }
}
