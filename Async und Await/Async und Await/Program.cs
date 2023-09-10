using System;
using System.Threading.Tasks;

namespace Async_und_Await
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting to make tea");
            await MakeTea();
            Console.WriteLine("serve");
        }

        static async Task<string> MakeTea()
        {
            var boilingWater = BoilWater();
            var water = await boilingWater;
            Console.WriteLine("pour " + water + " in Cups");
            return water;
        }

        static async Task<string> BoilWater()
        {
            await Task.Delay(2000);
            return "water";
        }
    }
}
