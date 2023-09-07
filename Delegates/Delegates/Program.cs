using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        delegate string einfacherDelegate(string m);

        delegate void Rechnungen(int m, int n);

        static void Main(string[] args)
        {
            einfacherDelegate hallo = Begruessung;
            Console.Write(hallo("Max"));



            Rechnungen n = Addition;
            n += Subtraction;
            n += Divider;
            n += Multiplier;
            
            n(10,5);
        }

        static public string Begruessung(string n)
        {
            return ("Hallo " + n + "!");
        }

        static public void Addition(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static public void Subtraction(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static public void Divider(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static public void Multiplier(int x, int y)
        {
            Console.WriteLine(x * y);
        }


    }
}
