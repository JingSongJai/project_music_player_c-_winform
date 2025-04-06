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
    public partial class PlaylistFolderUserControl : UserControl
    {
        public event EventHandler userClick; 

        public Image Image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public bool setVisible
        {
            get { return button1.Visible; }
            set { button1.Visible = value; }
        }

        public PlaylistFolderUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.userClick?.Invoke(this, e); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.Delete(@"Playlists\" + label1.Text);
            Program.mForm.panelDisplay.Controls.Clear();
            Program.mForm.panelDisplay.Controls.Add(new PlaylistUserControl() { Dock = DockStyle.Fill }); 
        }
    }
}
