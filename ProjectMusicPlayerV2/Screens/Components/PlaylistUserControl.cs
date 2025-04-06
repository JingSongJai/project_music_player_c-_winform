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
    public partial class PlaylistUserControl : UserControl
    {
        public PlaylistUserControl()
        {
            InitializeComponent();
        }

        private void PlaylistUserControl_Load(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories("Playlists");

            if (dirs.Length != 0)
            {
                foreach (string dir in dirs)
                {
                    flowLayoutPanel3.Controls.Add(new PlaylistFolderUserControl() { Image = new Utilities.Helper() { path = @"images\Music-Playlist.png" }.CopyImage(), Title = dir.Remove(0, 10) });
                }
            }

            playlistFolderUserControl5.userClick += showAddPlaylistForm_EventHandler; 

            foreach(PlaylistFolderUserControl control1 in flowLayoutPanel2.Controls)
            {
                control1.userClick += userClicked_EventHandler; 
            }

            foreach(PlaylistFolderUserControl control2 in flowLayoutPanel3.Controls)
            {
                if(control2.Name != "playlistFolderUserControl5")
                {
                    control2.userClick += userClicked_EventHandler;  
                }
            }
        }

        private void showAddPlaylistForm_EventHandler(object sender, EventArgs e)
        {
            new AddPlaylistForm().ShowDialog();
        }

        private void userClicked_EventHandler(object sender, EventArgs e)
        {
            switch (((PlaylistFolderUserControl)sender).Title)
            {
                case "Recently":
                    Program.mForm.panelDisplay.Controls.Clear();
                    Program.mForm.panelDisplay.Controls.Add(new MusicInPlaylistUserControl() { setTitle = "Recently", Dock = DockStyle.Fill }); 
                    break; 
                case "Favourites":
                    Program.mForm.panelDisplay.Controls.Clear();
                    Program.mForm.panelDisplay.Controls.Add(new MusicInPlaylistUserControl() { setTitle = "Favourites", Dock = DockStyle.Fill }); 
                    break;
                default:
                    Program.mForm.panelDisplay.Controls.Clear();
                    Program.mForm.panelDisplay.Controls.Add(new MusicInPlaylistUserControl() { setTitle = ((PlaylistFolderUserControl)sender).Title, Dock = DockStyle.Fill });
                    break; 
            }
        }
    }
}
