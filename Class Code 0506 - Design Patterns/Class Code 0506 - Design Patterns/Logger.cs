using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Class_Code_0506___Design_Patterns
{
    class Logger
    {
        private static Logger instance;
        static object key = new object();
        
        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                lock(key)
                {
                    if (instance == null)
                        instance = new Logger();
                }
            }
            return instance;
        }
        public void WriteLog(string text)
        {
            //Way 1 - StreamWriter
            using (StreamWriter stream = new StreamWriter(@"C:\meir\LoggerText.txt", true))
            {
                stream.Write($"{text} ");
            }
            //Way 2 - AppConfig.
            string path = ConfigurationSettings.AppSettings["Log"];
            File.AppendAllText(path, $"{text} ");
        }
    }
}
