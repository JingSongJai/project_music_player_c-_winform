using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.CodeDom.Compiler;

namespace ProjectMusicPlayerV2.Screens.Components
{

    public partial class MusicUserControl : UserControl
    {
        internal bool isPlayed = false, isFavourite = false, isShuffle = false;
        string[] files;
        internal List<string> mList = new List<string>();
        int currentIndex = Properties.Settings.Default.preSongIndex;
        private SongInfo songinfo; 
        private List<SongInfo> songlist = new List<SongInfo>();
        private JArray jsonArray = new JArray();
        private string tmp; 

        public MusicUserControl()
        {
            InitializeComponent();
        }

        public string setTitle
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public Image setPlay_Pause
        {
            get { return button1.Image; }
            set { button1.Image = value; }
        }

        public string setDuration
        {
            get { return labelDuration.Text; }
            set { labelDuration.Text = value; }
        }

        private async void MusicUserControl_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.isScanned = false;
            if (Properties.Settings.Default.isScanned)
            {
                await Task.Run(() => addSongsToDataGridView()); 
                //await checkIfSongsExist();
            }
        }

        private async Task checkIfSongsExist()
        {
            string newJsonString = "";
            string jsonString;
            List<string> tmp = new List<string>(); 

            using (StreamReader reader = new StreamReader("songinfo.json"))
            {
                jsonString = await reader.ReadToEndAsync();
            }
            jsonArray = JArray.Parse(jsonString);
            foreach (string path in mList)
            {
                if (!File.Exists(path))
                {
                    //mList.Remove(path);
                    tmp.Add(path); 
                    JObject songToDelete = jsonArray.FirstOrDefault(obj => (string)obj["path"] == path) as JObject;
                    if (songToDelete != null) jsonArray.Remove(songToDelete);


                    if (!File.Exists($"Recently\\{Path.GetFileNameWithoutExtension(path)}.txt")) File.Delete($"Recently\\{Path.GetFileNameWithoutExtension(path)}.txt");
                    if (!File.Exists($"Favourites\\{Path.GetFileNameWithoutExtension(path)}.txt")) File.Delete($"Favourites\\{Path.GetFileNameWithoutExtension(path)}.txt");
                    foreach (string folder in Directory.GetDirectories("Playlists"))
                    {
                        if (!File.Exists($"{folder}\\{Path.GetFileNameWithoutExtension(path)}.txt")) File.Delete($"{folder}\\{Path.GetFileNameWithoutExtension(path)}.txt");
                    }
                }
            }
            newJsonString = JsonSerializer.Serialize(jsonArray, new JsonSerializerOptions() { WriteIndented = true });

            foreach(string removePath in tmp)
            {
                mList.Remove(removePath); 
            }

            File.WriteAllText("songinfo.json", newJsonString);

            //dataGridView1.Rows.Clear();
            //songlist = new List<SongInfo>();
            //songlist = JsonSerializer.Deserialize<List<SongInfo>>(newJsonString);

            //foreach (SongInfo song in songlist)
            //{
            //    dataGridView1.Invoke(new Action(() =>
            //    {
            //        dataGridView1.Rows.Add(new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage(), song.Name, "Unknow", song.Duration);
            //    }));
            //}
        }

        private async Task addSongsToDataGridView()
        {
            mList.Clear(); 
            string jsonString;

            using (StreamReader reader = new StreamReader("songinfo.json"))
            {
                jsonString = await reader.ReadToEndAsync();
            }

            songlist = new List<SongInfo>();
            songlist = JsonSerializer.Deserialize<List<SongInfo>>(jsonString);

            foreach (SongInfo song in songlist)
            {
                mList.Add(song.Path); 
                dataGridView1.Invoke(new Action(() =>
                {
                    dataGridView1.Rows.Add(new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage(), song.Name, "Unknow", song.Duration);
                }));
            }

            checkPreviousSong();
            labelProcess.Invoke(new Action(() => { labelProcess.Text = mList.Count().ToString() + " Song(s)"; })); 
        }

        private async Task LoadAndAddMusics()
        {
            songlist.Clear(); 
            buttonScan.Loading = true;
            DriveInfo[] drives = DriveInfo.GetDrives();
            string jsonString = "";
            string[] exts = { ".wav", "mp3", ".aac", ".flac" };

            foreach (string ext in exts)
            {
                files = await GetFilesSafeAsync(drives[1].Name, "*." + ext, SearchOption.AllDirectories);
                if (files.Length == 0) continue;
                foreach (string file in files)
                {
                    try
                    {
                        using (AudioFileReader music = new AudioFileReader(file))
                        {
                            var duration = music.TotalTime;
                            songinfo = new SongInfo();
                            songinfo.Name = Path.GetFileNameWithoutExtension(file);
                            songinfo.Duration = duration.Minutes.ToString() + ":" + duration.Seconds.ToString("D2");
                            songinfo.Path = file;
                            songlist.Add(songinfo);
                        }
                    } catch (Exception ex)
                    {
                    }
                }
            }

            jsonString = JsonSerializer.Serialize(songlist, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText("songinfo.json", jsonString);
            dataGridView1.Invoke(new Action(() =>
            {
                dataGridView1.Rows.Clear();
            })); 
            await addSongsToDataGridView(); 
            Properties.Settings.Default.isScanned = true;
            Properties.Settings.Default.Save(); 
        }

        private void checkPreviousSong()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                string selectedDuration = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string selectedSong = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //spin1.Visible = false;
                if (Properties.Settings.Default.preSongTitle == "")
                {
                    label1.Text = selectedSong;
                    labelDuration.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    Program.mPlayer.URL = mList[0];
                }
                else
                {
                    label1.Invoke(new Action(() => { label1.Text = Properties.Settings.Default.preSongTitle; }));
                    labelDuration.Invoke(new Action(() =>
                    {
                        labelDuration.Text = Properties.Settings.Default.preSongDuration;
                    })); 
                    Program.mPlayer.URL = Properties.Settings.Default.preSongURL;
                    dataGridView1.Rows[Properties.Settings.Default.preSongIndex].Selected = true;
                    //dataGridView1.FirstDisplayedScrollingRowIndex = Properties.Settings.Default.preSongIndex; 
                }
                Program.mPlayer.controls.stop();
                slider1.MaxValue = int.Parse(selectedDuration.Split(':')[0]) * 60 + int.Parse(selectedDuration.Split(':')[1]);
            }
        }

        private async Task<string[]> GetFilesSafeAsync(string rootPath, string searchPattern, SearchOption searchOption)
        {
            List<string> files = new List<string>();

            try
            {
                files.AddRange(await GetFilesAsync(rootPath, searchPattern, SearchOption.TopDirectoryOnly));

                if (searchOption == SearchOption.AllDirectories)
                {
                    foreach (string directory in Directory.GetDirectories(rootPath))
                    {
                        labelProcess.Invoke(new Action(() =>
                        {
                            labelProcess.Text = directory; 
                        }));
                        try
                        {
                            files.AddRange(await GetFilesSafeAsync(directory, searchPattern, searchOption));
                        }
                        catch (Exception ex)
                        {
                            // Handle or log other possible exceptions
                            Console.WriteLine($"An error occurred: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or log other possible exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return files.ToArray();
        }

        private Task<string[]> GetFilesAsync(string path, string searchPattern, SearchOption searchOption)
        {
            return Task.Run(() =>
            {
                try
                {
                    return Directory.GetFiles(path, searchPattern, searchOption);
                }
                catch (Exception ex)
                {
                    // Handle or log other possible exceptions
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return Array.Empty<string>();
                }
            });
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage();
            slider1.Value = 0; 
            timer2.Stop(); 
            Program.mPlayer.controls.stop(); 
            string selectedSong = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string selectedDuration = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            slider1.MaxValue = int.Parse(selectedDuration.Split(':')[0]) * 60 + int.Parse(selectedDuration.Split(':')[1]);
            timer2.Start();
            label1.Text = selectedSong;
            button1.Image = new Utilities.Helper() { path = @"images/pause.png" }.CopyImage();
            isPlayed = true; 
            labelDuration.Text = selectedDuration;
            tmp = selectedDuration; 

            Properties.Settings.Default.preSongTitle = selectedSong;
            Properties.Settings.Default.preSongDuration = selectedDuration;
            
            try
            {
                foreach (string list in mList)
                {
                    if (list.Contains(selectedSong))
                    {
                        currentIndex = mList.IndexOf(list); 
                        Program.mPlayer.URL = list;
                        new Utilities.Helper() { path = @"Recently\" + Path.GetFileNameWithoutExtension(list) + ".txt", data = list }.addMusic(); 
                        Program.mPlayer.controls.play();
                    }
                }
            }
            catch (Exception ex) {}

            if (File.Exists(@"Favourites\" + selectedSong + ".txt"))
            {
                button4.Image = new Utilities.Helper() { path = @"images\favourite.png" }.CopyImage();
                isFavourite = true;
            }
            else
            {
                button4.Image = new Utilities.Helper() { path = @"images\favourite-line.png" }.CopyImage();
                isFavourite = false;
            }

            Properties.Settings.Default.preSongURL = Program.mPlayer.URL;
            Properties.Settings.Default.preSongIndex = currentIndex; 
            Properties.Settings.Default.Save();

            dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/wave-icon.png" }.CopyImage();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
            {
                string selectedDuration = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string selectedSong = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //spin1.Visible = false;
                if (Properties.Settings.Default.preSongTitle == "")
                {
                    label1.Text = selectedSong;
                    labelDuration.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    Program.mPlayer.URL = mList[0];
                }
                else
                {
                    label1.Text = Properties.Settings.Default.preSongTitle;
                    labelDuration.Text = Properties.Settings.Default.preSongDuration;
                    Program.mPlayer.URL = Properties.Settings.Default.preSongURL;
                    dataGridView1.Rows[Properties.Settings.Default.preSongIndex].Selected = true;
                    //dataGridView1.FirstDisplayedScrollingRowIndex = Properties.Settings.Default.preSongIndex; 
                }
                Program.mPlayer.controls.stop();
                slider1.MaxValue = int.Parse(selectedDuration.Split(':')[0]) * 60 + int.Parse(selectedDuration.Split(':')[1]);
                timer1.Stop(); 
            }
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); 
            foreach(string list in mList)
            {
                if (list.ToLower().Contains(input1.Text.ToLower()))
                {
                    //MessageBox.Show(Path.GetFileNameWithoutExtension(list));
                    using (AudioFileReader music = new AudioFileReader(list))
                    {
                        var duration = music.TotalTime;
                        dataGridView1.Rows.Add(new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage(), Path.GetFileNameWithoutExtension(list), "Unkown", duration.Minutes.ToString() + ":" + duration.Seconds.ToString("D2"));
                    }
                }
            }
            if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows.Count >= currentIndex)
            {
                dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/wave-icon.png" }.CopyImage();
                dataGridView1.Rows[currentIndex].Selected = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (labelDuration.Text.Split(':')[1] == "00")
            {
                labelDuration.Text = (int.Parse(labelDuration.Text.Split(':')[0]) - 1).ToString() + ":" + "59"; 
            }
            else
            {
                labelDuration.Text = labelDuration.Text.Split(':')[0] + ":" + ((int.Parse(labelDuration.Text.Split(':')[1]) - 1)).ToString("0#"); 
            }
            slider1.Value += 1;
            if (slider1.Value == slider1.MaxValue) timer2.Stop(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            //dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage();
            string selectedSong = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
            if (isPlayed)
            {
                Program.mPlayer.controls.pause(); 
                isPlayed = false;
                button1.Image = button1.Image = new Utilities.Helper() { path = @"images/play.png" }.CopyImage();
                timer2.Stop(); 
            }
            else
            {
                Program.mPlayer.controls.play(); 
                isPlayed = true;
                button1.Image = button1.Image = new Utilities.Helper() { path = @"images/pause.png" }.CopyImage();
                timer2.Start(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slider1.Value = 0;
            if (dataGridView1.Rows.Count == 0) return;
            button1.Image = new Utilities.Helper() { path = @"images/pause.png" }.CopyImage();
            dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage();
            timer2.Stop();
            Program.mPlayer.controls.stop();

            if (currentIndex == dataGridView1.Rows.Count - 1)
            {
                currentIndex = 0;
                Program.mPlayer.URL = mList[currentIndex];
                dataGridView1.Rows[currentIndex].Selected = true;
            }
            else
            {
                Program.mPlayer.URL = mList[currentIndex + 1];
                dataGridView1.Rows[currentIndex + 1].Selected = true;
                currentIndex++;
            }
            Program.mPlayer.controls.play();
            string selectedSong = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string selectedDuration = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            if (File.Exists(@"Favourites\" + selectedSong + ".txt"))
            {
                button4.Image = new Utilities.Helper() { path = @"images\favourite.png" }.CopyImage();
                isFavourite = true;
            }
            else
            {
                button4.Image = new Utilities.Helper() { path = @"images\favourite-line.png" }.CopyImage();
                isFavourite = false;
            }

            dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/wave-icon.png" }.CopyImage();
            slider1.MaxValue = int.Parse(selectedDuration.Split(':')[0]) * 60 + int.Parse(selectedDuration.Split(':')[1]);
            label1.Text = selectedSong;
            labelDuration.Text = selectedDuration;

            Properties.Settings.Default.preSongTitle = selectedSong;
            Properties.Settings.Default.preSongDuration = selectedDuration;
            Properties.Settings.Default.preSongURL = Program.mPlayer.URL;
            Properties.Settings.Default.preSongIndex = currentIndex;
            Properties.Settings.Default.Save();

            new Utilities.Helper() { path = @"Recently\" + Path.GetFileNameWithoutExtension(label1.Text) + ".txt", data = Program.mPlayer.URL }.addMusic();

            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slider1.Value = 0; 
            if (dataGridView1.Rows.Count == 0) return;
            button1.Image = new Utilities.Helper() { path = @"images/pause.png" }.CopyImage();
            dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage();
            timer2.Stop();
            Program.mPlayer.controls.stop();
            if (currentIndex != 0)
            {
                Program.mPlayer.URL = mList[currentIndex - 1];
                dataGridView1.Rows[currentIndex - 1].Selected = true;
                currentIndex--;
            }
            else
            {
                Program.mPlayer.URL = mList[mList.Count - 1];
                dataGridView1.Rows[mList.Count - 1].Selected = true;
                currentIndex = mList.Count - 1; 
            }

            Program.mPlayer.controls.play();
            string selectedSong = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string selectedDuration = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            if (File.Exists(@"Favourites\" + selectedSong + ".txt"))
            {
                button4.Image = new Utilities.Helper() { path = @"images\favourite.png" }.CopyImage();
                isFavourite = true;
            }
            else
            {
                button4.Image = new Utilities.Helper() { path = @"images\favourite-line.png" }.CopyImage();
                isFavourite = false;
            }

            dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/wave-icon.png" }.CopyImage();
            slider1.MaxValue = int.Parse(selectedDuration.Split(':')[0]) * 60 + int.Parse(selectedDuration.Split(':')[1]);
            label1.Text = selectedSong;
            labelDuration.Text = selectedDuration;

            Properties.Settings.Default.preSongTitle = selectedSong;
            Properties.Settings.Default.preSongDuration = selectedDuration;
            Properties.Settings.Default.preSongURL = Program.mPlayer.URL;
            Properties.Settings.Default.preSongIndex = currentIndex;
            Properties.Settings.Default.Save();

            new Utilities.Helper() { path = @"Recently\" + Path.GetFileNameWithoutExtension(label1.Text) + ".txt", data = Program.mPlayer.URL }.addMusic();

            timer2.Start(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private async void buttonCancel_Click(object sender, EventArgs e)
        {
            if (buttonScan.Loading) return;

            if (!Properties.Settings.Default.isScanned)
            {
                await LoadAndAddMusics();
                buttonScan.Loading = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to scan again? If you do, it may take some times!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

                if(result == DialogResult.Yes)
                {
                    await Task.Run(() => LoadAndAddMusics());
                    button1.Image = button1.Image = new Utilities.Helper() { path = @"images/play.png" }.CopyImage();
                    slider1.Value = 0;
                    labelDuration.Text = tmp; 
                    buttonScan.Loading = false;
                }
            }
        }

        private void input1_TextChanged(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (string list in mList)
            {
                if (list.ToLower().Contains(input1.Text.ToLower()))
                {
                    //MessageBox.Show(Path.GetFileNameWithoutExtension(list));
                    using (AudioFileReader music = new AudioFileReader(list))
                    {
                        var duration = music.TotalTime;
                        dataGridView1.Rows.Add(new Utilities.Helper() { path = @"images/play-icon.png" }.CopyImage(), Path.GetFileNameWithoutExtension(list), "Unkown", duration.Minutes.ToString() + ":" + duration.Seconds.ToString("D2"));
                    }
                }
            }
            if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows.Count >= currentIndex)
            {
                dataGridView1.Rows[currentIndex].Cells[0].Value = new Utilities.Helper() { path = @"images/wave-icon.png" }.CopyImage();
                dataGridView1.Rows[currentIndex].Selected = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (isShuffle)
            {
                button5.Image = new Utilities.Helper() { path = @"images\shuffle-off.png" }.CopyImage();
                isShuffle = false; 
            }
            else
            {
                button5.Image = new Utilities.Helper() { path = @"images\shuffle-on.png" }.CopyImage();
                isShuffle = true; 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;

            string selectedSong = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string selectedDuration = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            if (isFavourite)
            {
                button4.Image = new Utilities.Helper() { path = @"images\favourite-line.png" }.CopyImage();
                if (File.Exists(@"Favourites\" + selectedSong + ".txt")) File.Delete(@"Favourites\" + selectedSong + ".txt"); 
                isFavourite = false; 
            }
            else
            {
                button4.Image = new Utilities.Helper() { path = @"images\favourite.png" }.CopyImage();
                new Utilities.Helper() { path = @"Favourites\" + selectedSong + ".txt", data = Program.mPlayer.URL }.addMusic();
                isFavourite = true; 
            }
        }
    }
}
