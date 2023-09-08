using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    class Grill
    {
        public delegate void GrillEventHandler(object source);
        public event GrillEventHandler Grilled;

        public void Braten (Gericht gericht)
        {
            Console.WriteLine("Gericht " + gericht.Name + " ist auf dem Grill!");
            Thread.Sleep(3000);

            OnGrilled();
        }

        protected virtual void OnGrilled ()
        {
            if (Grilled != null)
            {
                Grilled(this); 
            }
        }
    }
}
