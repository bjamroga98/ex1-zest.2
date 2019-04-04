using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_zest._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new array { { 1, 5, 8 }, { 7, 9, 4 }, { 2, 1, 0 }, { 6, 0, 3 } };
            for (int i = 0; i<array.GetLength(0); ++i)
            {
                for (int j = 0; j<array.GetLength(0); ++j)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i<array.GetLength(0); ++i)
            {
                int rowsum = 0;
                for (int j = 0; j<array.GetLength(0); ++j)
                {
                    rowsum += array[i, j];
                }
                Console.WriteLine("Sum of row {0}:   {1}", i, rowsum);
            }
        }Console.Readkey();
    }
}
