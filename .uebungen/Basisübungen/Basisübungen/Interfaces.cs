using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basisübungen
{
    public interface IShape
    {
        double CalculateArea(int x = 0, int y = 0, int z = 0);
    }

    public class Kreis : IShape
    {
        public double CalculateArea(int radius, int opt1 = 0, int opt2 = 0)
        {
            return radius * (2 * Math.PI);
        }
    }

    public class Dreieck : IShape 
    { 
        public double CalculateArea(int a, int b, int opt2 = 0)
        {
            return (1 / 2) * a * b;
        }
    }

}
