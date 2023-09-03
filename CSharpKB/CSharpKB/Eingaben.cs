using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    class Eingaben
    {
        public static void Consolenausgabe()
        {
            string input = Console.ReadLine();
            Console.WriteLine("---");
            Console.WriteLine(input);

            Console.Write("Bitte Benutzername eingeben: ");
            string username = Console.ReadLine();
            Console.WriteLine("Hallo " + username);
        }
    }
}
