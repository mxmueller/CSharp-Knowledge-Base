using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funktionen.GreetUser("Max");

            double ra = Funktionen.RectangleArea(54.3, 2345.2);
            Console.WriteLine(ra);

            Eingaben.Consolenausgabe();

        }
    }
}
