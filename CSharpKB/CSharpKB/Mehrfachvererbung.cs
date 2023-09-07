using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    public interface ITier
    {
        void laufen(); // Abstrakte Methode
    }

    public interface IGewicht
    {
        int gewicht();
    }

    public class Hund : ITier, IGewicht
    {
        public void laufen()
        {
            Console.WriteLine("Hund läuft");
        }

        public int gewicht()
        {
            return 100;
        }
    }

    public class Katze : ITier
    {
        public void laufen()
        {
            Console.WriteLine("Katze läuft");
        }
    }
}
