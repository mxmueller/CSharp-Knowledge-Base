using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    class Auto
    {
        public String bezeichnung;
        public int leistung;
        public int raeder;
        private int tueren;
        public static String typ = "Kraftfahrzeug";
        
        public int Tueren
        {
            get { return tueren; }
            set { if(value > 0) 
                    tueren = value; }
        }

        public Auto(String name, int ps, int anzahlRaeder = 4) // Konstruktor
        {
            bezeichnung = name;
            leistung = ps;
            raeder = anzahlRaeder;
        }

        public double mph()
        {
            return leistung * 1.6;
        }   
    }
}
