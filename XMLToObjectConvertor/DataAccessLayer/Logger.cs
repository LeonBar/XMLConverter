using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToObjectConvertor.DataAccessLayer
{
    public class Logger
    {
        private static string filePath = ConfigurationSettings.AppSettings["LoggerFilePath"];

        public static void Write(string message)
        {
            try
            {
                string strFileName = Path.Combine(filePath, String.Format("{0}{1}_LOG.log", filePath, DateTime.Now.ToString("yyyyMMdd")));

                StreamWriter writer = new StreamWriter(strFileName, true);
                writer.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "  ->  " + message);
                writer.Close();
            }
            catch { }
        }
    }
}
