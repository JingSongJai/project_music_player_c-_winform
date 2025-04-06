using NAudio.Wave;
using ProjectMusicPlayerV2.Screens.Components;
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

namespace ProjectMusicPlayerV2.Screens
{
    public partial class MusicListUserControl : Form
    {
        internal string folder; 

        public MusicListUserControl()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void MusicListUserControl_Load(object sender, EventArgs e)
        {
            foreach (string list in Program.mc.mList)
            {
                using (AudioFileReader reader = new AudioFileReader(list))
                {
                    var duration = reader.TotalTime;
                    dataGridView1.Rows.Add(new Utilities.Helper() { path = @"images\music-icon.png" }.CopyImage(), Path.GetFileNameWithoutExtension(list), "Unknow", duration.Minutes.ToString() + ":" + duration.Seconds.ToString("D2"));
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            labelCount.Text = dataGridView1.SelectedRows.Count.ToString(); 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<string> selectedSong = new List<string>(); 
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                new Utilities.Helper() { path = "Playlists\\" + folder +"\\" + Path.GetFileNameWithoutExtension(Program.mc.mList[row.Index]) + ".txt", data = Program.mc.mList[row.Index] }.addMusic(); 
            }
            this.Close();
            Program.mForm.panelDisplay.Controls.Clear();
            Program.mForm.panelDisplay.Controls.Add(new MusicInPlaylistUserControl() { setTitle = folder }); 
        }
    }
}