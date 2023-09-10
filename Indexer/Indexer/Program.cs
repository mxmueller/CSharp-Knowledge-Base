using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team mannschaft = new Team();
            Console.WriteLine(mannschaft[1].Name); // mit Indexer zugreifen
        }
    }

    class Team
    {
        List<Spieler> spielerListe = new List<Spieler>();

        public Team()
        {
            spielerListe.Add(new Spieler() { Name = "Horst" });
            spielerListe.Add(new Spieler() { Name = "Max" });
            spielerListe.Add(new Spieler() { Name = "Franz" });
            spielerListe.Add(new Spieler() { Name = "Manni" });
            spielerListe.Add(new Spieler() { Name = "Tami" });
        }

        public Spieler this[int index] // Indexer hinzufügen
        {
            get { return spielerListe[index];  }
            set { spielerListe[index] = value; }
        }
    }

    class Spieler
    {
        public string Name { get; set; }
    }
}
