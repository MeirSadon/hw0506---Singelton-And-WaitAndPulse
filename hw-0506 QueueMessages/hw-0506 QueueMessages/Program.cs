using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hw_0506_QueueMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncPrinter ap = new AsyncPrinter();
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(ap.CheckPrintMessage);
                t.Start();
            }
            for (int i = 0; i < 21; i++)
            {
                Thread t1 = new Thread(() => ap.AddMessage($"{DateTime.Now}"));
                t1.Start();
            }
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(ap.CheckPrintMessage);
                t.Start();
            }
            while (true)
            {

            }
        }
    }
}
