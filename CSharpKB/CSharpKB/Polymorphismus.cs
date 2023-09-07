using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    public abstract class Fahrrad 
    {
        public virtual void geschwindigkeit()
        {
            Console.WriteLine("normal schnell");
        }
        public abstract int rahmengroeße();
    }

    class Damenrad : Fahrrad 
    {
        public override int rahmengroeße()
        {
            return 50;
        }
    }

    class Rennrad : Fahrrad
    {
        public override void geschwindigkeit() 
        {
            Console.WriteLine("sehr schnell");
        }

        public override int rahmengroeße()
        {
            return 60;
        }
    }
}
