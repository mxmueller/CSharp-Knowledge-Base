using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKB
{
    internal class Arrays
    {
        public static void GiveMeArrays()
        {
            int[] eindimensionalesArray = new int[] { 4, 6, 3, 2, 6, 8, 2 };
            
            foreach (int i in eindimensionalesArray)
            {
               Console.WriteLine(i);
            }


            int[,] zweidimensionalesArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };


            int rows = zweidimensionalesArray.GetLength(0);
            int cols = zweidimensionalesArray.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine(zweidimensionalesArray[i, j]);
                }
            }
        }
    }
}
