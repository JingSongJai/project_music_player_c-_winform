using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace ProjectMusicPlayerV2.Screens.Components
{
    public partial class MusicInPlaylistUserControl : UserControl
    {
        List<string> mList = new List<string>();
        int currentIndex; 

        public MusicInPlaylistUserControl()
        {
            InitializeComponent();
        }

        public string setTitle
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }

        private void MusicInPlaylistUserControl_Load(object sender, EventArgs e)
        {
            string[] filePaths;
            switch (labelTitle.Text)
            {
                case "Recently":
                    filePaths = Directory.GetFiles("Recently");
                    buttonAdd.Visible = false; 
                    break;
                case "Favourites":
                    filePaths = Directory.GetFiles("Favourites");
                    buttonAdd.Visible = false; 
                    break;
                default:
                    filePaths = Directory.GetFiles(@"Playlists\" + labelTitle.Text); 
                    break; 
            }

            if (filePaths.Length == 0) return;

            foreach (string filePath in filePaths)
            {
                mList.Add(new Utilities.Helper() { path = filePath }.getMusicData());
            }

            foreach (string list in mList)
            {

                using (AudioFileReader reader = new AudioFileReader(list))
                {
                    var duration = reader.TotalTime;
                    dataGridView1.Rows.Add(new Utilities.Helper() { path = @"images\play-icon.png" }.CopyImage(), Path.GetFileNameWithoutExtension(list), "Unknow", duration.Minutes.ToString() + ":" + duration.Seconds.ToString("D2"));
                }
            }

            if (dataGridView1.Rows.Count != 0 && mList.IndexOf(Program.mPlayer.URL) != -1)
            {
                currentIndex = mList.IndexOf(Program.mPlayer.URL);
                dataGridView1.Rows[mList.IndexOf(Program.mPlayer.URL)].Selected = true;
                if (Program.mc.isPlayed) dataGridView1.Rows[mList.IndexOf(Program.mPlayer.URL)].Cells[0].Value = new Utilities.Helper() { path = @"images\wave-icon.png" }.CopyImage();
                //dataGridView1.FirstDisplayedScrollingRowIndex = mList.IndexOf(Program.mPlayer.URL);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (Program.mc.dataGridView1.Rows.Count == 0) return;
            if (dataGridView1.Rows.Count == 0) return;
            string selectedSong = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string selectedDuration = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage();
            Program.mPlayer.controls.stop();
            Program.mc.slider1.Value = 0;
            Program.mc.dataGridView1.Rows[Program.mc.mList.IndexOf(Program.mPlayer.URL)].Cells[0].Value = new Utilities.Helper() { path = @"images\play-icon.png" }.CopyImage();

            try
            {
                foreach (string list in mList)
                {
                    if (list.Contains(selectedSong))
                    {
                        currentIndex = mList.IndexOf(list);
                        Program.mPlayer.URL = list;
                        Program.mPlayer.controls.play();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/wave-icon.png" }.CopyImage();
            Program.mc.setTitle = selectedSong; 
            Program.mc.setDuration = selectedDuration;
            Program.mc.setPlay_Pause = new Utilities.Helper() { path = @"images\pause.png" }.CopyImage();
            Program.mc.slider1.MaxValue = int.Parse(selectedDuration.Split(':')[0]) * 60 + int.Parse(selectedDuration.Split(':')[1]);
            Program.mc.dataGridView1.Rows[Program.mc.mList.IndexOf(Program.mPlayer.URL)].Selected = true;
            Program.mc.dataGridView1.Rows[Program.mc.mList.IndexOf(Program.mPlayer.URL)].Cells[0].Value = new Utilities.Helper() { path = @"images\wave-icon.png" }.CopyImage(); 
            Program.mc.timer2.Start(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.mForm.panelDisplay.Controls.Clear();
            Program.mForm.panelDisplay.Controls.Add(new PlaylistUserControl() { Dock = DockStyle.Fill }); 
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            string path;
            if (labelTitle.Text == "Recently" || labelTitle.Text == "Favourites") path = labelTitle.Text;
            else path = @"Playlists\" + labelTitle.Text; 

            dataGridView1.Rows.Clear(); 
            foreach(string file in Directory.GetFiles(path))
            {
                File.Delete(file); 
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new Screens.MusicListUserControl() { folder = labelTitle.Text }.ShowDialog(); 
        }
    }
}
