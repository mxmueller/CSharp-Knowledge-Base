using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(23, "Antwort auf alle Fragen");
            dict.Add(76, "Test");
            dict.TryGetValue(23, out string abc);
            Console.WriteLine(abc);
        }
    }
}
