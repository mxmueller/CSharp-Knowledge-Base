using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basisübungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a0();
            //a1();
            //a2();
            //d0();
            //d1();
            // k1();
            // k2();
            // k3();
        }
        public static void k2()
        {
            Bankkonto sparkasse = new Bankkonto(
                08803442123223,
                "Maximilian Mueller",
                4000
                );

            double savings = sparkasse.Transfer(30);
            Console.WriteLine(savings);

            savings = sparkasse.Deposite(5000);
            Console.WriteLine(savings);
        }

        class Bankkonto
        {
            public long Kontonummer { get; set; }
            public string Inhabername { get; set; }

            private double kontostand;

            public double Kontostand
            {
                get { return kontostand; }
                set {
                    if (value >= 0)
                    {
                        kontostand = value;
                    } else
                    {
                        Console.WriteLine("Kontostand darf nicht überzogen werden!");
                    }
                }
            }

            public Bankkonto (long defKontonummer, string defInhaber, double defKontostand)
            {
                Kontonummer = defKontonummer;
                Inhabername = defInhaber;
                Kontostand = defKontostand;
            }

            public double Transfer(double amount)
            {
                Kontostand = Kontostand + amount;
                return Kontostand;
            }

            public double Deposite(double amount)
            {
                double temp = Kontostand - amount;
                if (temp < 0)
                {
                    Console.WriteLine("Keine Überziehung erlaubt!");
                    return Kontostand;
                } else
                {
                    Kontostand = temp;
                    return temp;
                }
            }
        }

        public static void k1()
        {
            Person max = new Person("Max", 23);
            max.PrintPerson();
        }

        class Person
        {
            private string name;
            public string Name { 
                get { return name; }
                set { name = value; } 
            }

            private int alter;
            public int Alter
            {
                get { return alter; }
                set { alter = value; }
            }

            public void PrintPerson()
            {
                Console.WriteLine(name + " ist " + alter + " jahre alt");
            }

            public Person (string defName, int defAlter)
            {
               Name = defName;
               Alter = defAlter;
            }
        }

        public static void d1()
        {
            Console.Write("Datum eingeben -> (formatiert: 00.00.0000) :");
            string dateInput1 = Console.ReadLine();

            Console.Write("ZweitesD atum eingeben -> (formatiert: 00.00.0000) :");
            string dateInput2 = Console.ReadLine();

            DateTime date1 = DateTime.Parse(dateInput1);
            DateTime date2 = DateTime.Parse(dateInput2);

            compareDates(date1, date2);
        }

        public static void compareDates(DateTime dt1, DateTime dt2)
        {
            int compare = DateTime.Compare(dt1, dt2);
            if (compare > 0) Console.WriteLine("liegt davor");
            if (compare < 0) Console.WriteLine("liegt zurück");
        }
    

        public static void d0()
        {
            DateTime date = DateTime.Now;
            string dateFromated = date.ToString("d");

            Console.WriteLine(dateFromated);
        }

        public static void a2()
        {
            string[] zeichen = new string[] { "d", "s", "b", "d", "b", "m", "i", "p" };
             
            Dictionary<string, int> zeichenzaehler = new Dictionary<string, int>();
            
            for (int m = 0; m < zeichen.Length; m++)
            {
                if (zeichenzaehler.ContainsKey(zeichen[m]))
                {
                    int counter = zeichenzaehler[zeichen[m]];
                    zeichenzaehler[zeichen[m]] = counter + 1;
                } else if (!zeichenzaehler.ContainsKey(zeichen[m]))
                {
                    zeichenzaehler[zeichen[m]] = 1;
                }
            }

            foreach(KeyValuePair<string, int> counting in zeichenzaehler)
            {
                Console.WriteLine("The key for {0} is {1}", counting.Value, counting.Key);
            }
        }


        public static void a1 ()
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };;
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
    
            for (int n = 0; n < x; n++) {
                int first = 0;
                int second = 0;
                int third = 0;
                for (int m = 0; m<y; m++)
                {
                    if (m == 0)
                        first = matrix[n, m];
                    if (m == 1)
                        second = matrix[n, m];
                    if (m == 2)
                        third = matrix[n, m];
                }

            Console.WriteLine(first + " | " + second + " | " + third);
            }
        }

        public static void Ganzzahlen(int[] nums)
        {
            int addUp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]); 
                addUp = addUp + nums[i];                
            }
            Console.WriteLine(addUp);
        }
        public static void a0()
        {
            int[] tests = new int[] { 1, 2, 3, 4 };
            Ganzzahlen(tests);
        }
}
}
