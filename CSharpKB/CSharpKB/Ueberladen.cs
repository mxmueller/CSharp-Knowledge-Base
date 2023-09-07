using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    class Vektor
    {
        public int a = 0;
        public int b = 0;

        public static Vektor operator +(Vektor x, Vektor y)
        {
            Vektor newVektor = new Vektor();
            newVektor.a = x.a * y.a;
            newVektor.b = x.b * y.b;
            return newVektor;   
        }
    }
}
