using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace console_boilerplate.Utility
{
    class Configurations
    {
        private static void ReadSetting()
        {
            var test = ConfigurationManager.AppSettings[""];
        }
    }
}
