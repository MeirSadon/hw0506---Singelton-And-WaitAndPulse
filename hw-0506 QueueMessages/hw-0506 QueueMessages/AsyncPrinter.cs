using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hw_0506_QueueMessages
{
    class AsyncPrinter
    {
        Queue<string> Messages = new Queue<string>();
        int howMuchWaiting = 0;
        int times = 1;

        public void AddMessage(string message)
        {
            lock(this)
            {
                Messages.Enqueue(message);
                Monitor.Pulse(this);
            }
        }
        public void CheckPrintMessage()
        {
            lock(this)
            {
                if (Messages.Count > 0)
                {
                    Console.WriteLine($"{times++}: {Messages.Dequeue()}");
                    return;
                }
                Monitor.Wait(this);
                Console.WriteLine($"{times++}: {Messages.Dequeue()}");
                return;
            }
        }
    }
}
