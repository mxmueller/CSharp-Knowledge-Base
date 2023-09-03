using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    class Funktionen
    {
        public static void GreetUser(string username)
        {
            Console.WriteLine("Hello " + username + "!");
            Greetings();
        }

        static void Greetings()
        {
            Console.WriteLine("Herzlich Willkommen!");
        }

        // mit Rückggabe:
        public static double RectangleArea(double width, double height)
        {
            return width * height;
        }



    }
}
