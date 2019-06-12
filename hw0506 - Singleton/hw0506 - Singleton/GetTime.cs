using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0506___Singleton
{
    class GetTime
    {
        static GetTime _instance { get; set; }
        static object key = new object();

        protected GetTime()
        {

        }
        static public GetTime GetInstance()
        {
            if(_instance == null)
            {
                lock(key)
                {
                    if(_instance == null)
                    {
                        _instance = new GetTime();
                    }
                }
            }
            return _instance;
        }

        public void PrintTime()
        {
            Console.WriteLine($"The Time Is: {DateTime.Now}");
        }
    }
}
