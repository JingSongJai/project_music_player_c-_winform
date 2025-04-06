using ProjectMusicPlayerV2.Screens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ProjectMusicPlayerV2
{
    internal static class Program
    {
        internal static Form1 mForm;
        internal static Screens.Components.MusicUserControl mc;
        internal static Screens.Components.PlaylistFolderUserControl pc;
        internal static WindowsMediaPlayer mPlayer; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Directory.CreateDirectory("Recently"); 
            Directory.CreateDirectory("Favourites");
            Directory.CreateDirectory("Playlists");
            
            mForm = new Form1(); 
            mc = new Screens.Components.MusicUserControl();
            pc = new Screens.Components.PlaylistFolderUserControl();
            mPlayer = new WindowsMediaPlayer();

            Application.Run(mForm);
        }
    }
}
