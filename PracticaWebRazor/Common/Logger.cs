using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PracticaWebRazor.Common
{
    public static class Logger
    {
        public static void Log (string mensaje)
        {
            File.AppendAllText(@"C:\Agustin\C Sharp\PracticaWebRazor\ArchivoLogs.txt", 
                string.Format("{0} - INFO: {1}", DateTime.Now, mensaje + Environment.NewLine));
        }
    }
}