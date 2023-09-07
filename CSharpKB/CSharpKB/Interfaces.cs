using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
   public interface ITier_1
    {
        void laufen(); // Abstrakte Methode
    }

    public class Hund_1 : ITier_1
    {
        public void laufen()
        {
            Console.WriteLine("Hund läuft");
        }
    }

    public class Katze_1 : ITier_1
    {
        public void laufen()
        {
            Console.WriteLine("Katze läuft");
        }
    }

}
