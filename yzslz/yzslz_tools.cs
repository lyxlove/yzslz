using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace yzslz
{
    class yzslz_tools
    {
        public static void WriteTxtLog(string str)
        {

            StreamWriter sw ;
            string strPath = string.Format(@"{0}\log_{1}.txt", System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            
        }

        private void CreateLogText(string path)
        {
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }
        }

    }
}