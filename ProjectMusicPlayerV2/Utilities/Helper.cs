using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMusicPlayerV2.Utilities
{
    internal class Helper
    {
        internal string path, data; 

        public Image CopyImage()
        {
            Image tmp = Image.FromFile(path);
            Bitmap img = new Bitmap(tmp);
            tmp.Dispose();
            return img; 
        }

        public void addMusic()
        {
            if (!File.Exists(Path.GetFileNameWithoutExtension(path))){
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(data);
                }
            }
        }

        public string getMusicData()
        {
            string tmp; 

            using (StreamReader reader = new StreamReader(path))
            {
                string getdata = reader.ReadLine();
                tmp = getdata; 
            }
            return tmp; 
        }
    }
}
