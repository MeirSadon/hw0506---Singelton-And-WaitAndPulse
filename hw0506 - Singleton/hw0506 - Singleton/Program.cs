using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0506___Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTime g1 = GetTime.GetInstance();
            GetTime g2 = GetTime.GetInstance();

            if(g1 == g2)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Not Same");

            g1.PrintTime();
            
        }
    }
}
