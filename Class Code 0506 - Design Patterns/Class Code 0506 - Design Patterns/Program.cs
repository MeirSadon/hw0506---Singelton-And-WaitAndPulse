using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Code_0506___Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.GetInstance().WriteLog("Hello");
            Logger.GetInstance().WriteLog("World");
        }
    }
}
