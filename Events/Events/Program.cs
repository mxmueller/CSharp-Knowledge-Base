using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {

        static void Main(string[] args)
        {
            var burger = new Gericht() { Name = "Cheeseburger" };
            var holzkohle = new Grill(); // publisher
            var server = new Serve(); // subscriber
            var plates = new Plates(); // subscriber

            holzkohle.Grilled += plates.SetupPlates;
            holzkohle.Grilled += server.NotifyServer;
            holzkohle.Braten(burger);
        }

    }
    public class Serve
    {
        public void NotifyServer(object source) 
        {
            Console.WriteLine("Gegrilltes ist bereit zum servieren");
        }
    }

    public class Plates
    {
        public void SetupPlates(object source)
        {
            Console.WriteLine("Teller fertig machen!");
        }
    }
}
