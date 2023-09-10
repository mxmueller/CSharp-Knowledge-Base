using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basisübungen
{
	public class Auto
	{
		private string marke;

		public string Marke
		{
			get { return marke; }
			set { marke = value; }
		}

		private string modell;

		public string Modell
		{
			get { return modell; }
			set { modell = value; }
		}

		private int jahr;

		public int Jahr
		{
			get { return jahr; }
			set { jahr = value; }
		}

        public bool moving = false;

        public Auto(string defMarke, string defModell, int defJahr)
		{
			Jahr = defJahr;
			Marke = defMarke;
			Modell = defModell;
		}

		public bool Start()
		{
			if (!moving) {
                moving = true;
                Console.WriteLine("gestartet!");
				return moving;
            }
				
			if (moving)
			{
                Console.WriteLine("Auto fährt berreits");
                return moving;
            }
            return false;
        }

		public bool Stop()
		{
			if (moving)
				moving = false;

			if (!moving)
				Console.WriteLine("Auto steht berreits");

			return moving;
		}
	}
}
