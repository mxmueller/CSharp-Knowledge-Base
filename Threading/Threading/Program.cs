using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(CountToHundret);
            t.Start();

            Thread n = new Thread(CountToHundret);
            n.Start();
        }

        static void CountToHundret()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
