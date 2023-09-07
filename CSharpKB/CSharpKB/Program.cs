using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> namensliste = new List<string>();
            namensliste.Add("Max");
            namensliste.Add("Uwe");
            namensliste.Add("Manni");

            Console.WriteLine(namensliste[0]);

            namensliste.Remove("Max");

            //double abc = 1.342;
            //int abcInt = (int)abc;
            //Console.WriteLine(abcInt); // = 1

            //Vektor eins = new Vektor();
            //eins.a = 2;
            //eins.b = 3;

            //Vektor zwei = new Vektor();
            //zwei.a = 12;
            //zwei.b = 13;

            //Fahrrad[] raeder = new Fahrrad[2];
            //raeder[0] = new Damenrad();
            //raeder[1] = new Rennrad();

            //raeder[0].geschwindigkeit();
            //raeder[1].geschwindigkeit

            //ITier_1[] tiere = new ITier_1[1];
            //tiere[0] = new Hund();
            //tiere[1] = new Katze();

            //tiere[0].laufen();
            //tiere[1].laufen();


            //Rennrad Canyon = new Rennrad();
            //Canyon.Marke = "Canyon";
            //Canyon.Gaenge = 12;
            //Console.WriteLine(Canyon.Infos());

            //Auto Mercedes = new Auto("Mercedes A-Klasse", 32);
            //Mercedes.Tueren = 5;
            //Console.WriteLine(Mercedes.marke + "hat: " + Mercedes.Tueren);


            // Arrays.GiveMeArrays();

            //Funktionen.GreetUser("Max");

            //double ra = Funktionen.RectangleArea(54.3, 2345.2);
            //Console.WriteLine(ra);

            //Eingaben.Consolenausgabe();

        }
    }
}
