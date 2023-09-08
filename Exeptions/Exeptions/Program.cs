using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] abc = new int[1];
                Console.WriteLine(abc[2]);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Data);
            }
        }
    }
}
