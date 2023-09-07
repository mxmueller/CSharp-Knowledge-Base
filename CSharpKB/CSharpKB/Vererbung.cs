using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{

    class Fahrrad_1
    {
        public string Marke { get; set; }
        public int Gaenge { get; set; }
    }

    class Rennrad_1 : Fahrrad_1
    {
        public string Infos()
        {
            return Marke;
        }
    }
}
