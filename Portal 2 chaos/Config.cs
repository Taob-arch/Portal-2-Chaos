using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_2_chaos
{
    class Config
    {
        public static string getInstallDir()
        {
            return File.ReadAllLines("./config.p2c")[1];
        }
        public static string getUsername()
        {
            return File.ReadAllLines("./config.p2c")[2];
        }
        public static string getOAuthToken()
        {
            return File.ReadAllLines("./config.p2c")[3];
        }
        public static string getChannelName()
        {
            return File.ReadAllLines("./config.p2c")[4];
        }
    }
}
