using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemStore = new ItemStore<int, double>();
            itemStore.Value = 5;
            itemStore.Value2 = 34.3;
        }
    }

    class ItemStore<Datentyp, AndererDatentyp>
    {
        public Datentyp Value { get; set; }
        public AndererDatentyp Value2 { get; set; }
    }
}
