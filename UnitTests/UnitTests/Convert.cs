using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class Convert
    {
        public static double f2c(double f)
        {
            return (f - 32) * 5 / 9;
        }

        public static double c2f(double c)
        {
            return (c * 9 / 5) + 32;
        }
    }
}
