using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Dmo;
using NAudio.Wave;
using ProjectMusicPlayerV2.Screens;
using WMPLib; 

namespace ProjectMusicPlayerV2
{
    public partial class Form1 : Form
    {
        private NotifyIcon trayIcon; 

        public Form1()
        {
            InitializeComponent();
            trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon(@"images/icon.ico");
            trayIcon.Text = "Amazing Music Player";
            trayIcon.Visible = true;
            trayIcon.DoubleClick += (s, e) =>
            {
                Show();
                WindowState = FormWindowState.Normal;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.mForm.panelDisplay.Controls.Add(Program.mc);
            //Task.Run(() =>
            //{
            //    Thread.Sleep(10000);
            //    //this.Invoke(new Action(() =>
            //    //{
            //        Program.mPlayer.controls.pause(); 
            //    //})); 
            //});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isHide) this.Hide();
            else this.Close(); 
        }

        private void tree1_SelectChanged(object sender, AntdUI.TreeItem item, Rectangle rect)
        {
            switch (item.Text)
            {
                case "Music":
                    Program.mForm.panelDisplay.Controls.Clear();
                    Program.mForm.panelDisplay.Controls.Add(Program.mc); 
                    break;
                case "Playlist":
                    Program.mForm.panelDisplay.Controls.Clear();
                    Program.mForm.panelDisplay.Controls.Add(new Screens.Components.PlaylistUserControl() { Dock = DockStyle.Fill }); 
                    break;
                case "About Me":
                    Program.mForm.panelDisplay.Controls.Clear();
                    Program.mForm.panelDisplay.Controls.Add(new Screens.Components.AboutUsUserControl() { Dock = DockStyle.Fill });
                    break;
                case "Settings":
                    Program.mForm.panelDisplay.Controls.Clear();
                    Program.mForm.panelDisplay.Controls.Add(new Screens.Components.SettingsUserControl() { Dock = DockStyle.Fill });
                    break; 
                case "Exit":
                    this.Close();
                    break; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void showWarningForm()
        {
            if (!Properties.Settings.Default.DontShow)
            {
                new WarningForm().ShowDialog(); 
            }
        }
    }
}
