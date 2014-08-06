using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace console_boilerplate.Utility
{
    class ErrorLogging
    {
        public static string ErrorLogFilename 
        {
            get
            {
                return ConfigurationManager.AppSettings["error-log-filename"] ?? "";
            }
            set
            {
                ConfigurationManager.AppSettings["error-log-filename"] = value;
            }
        }

        public static void LogError(Exception ex)
        {
            string entry = string.Format("{0} - {1}{2}{3}{4}{5}{6}", DateTime.Now, ex.Message, Environment.NewLine, ex.InnerException == null ? "" : ex.InnerException.Message ?? "", Environment.NewLine, ex.StackTrace, Environment.NewLine);
            File.AppendAllText(ErrorLogFilename, entry);
        }
    }
}
