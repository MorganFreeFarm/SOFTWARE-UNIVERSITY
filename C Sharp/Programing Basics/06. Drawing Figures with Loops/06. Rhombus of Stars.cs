using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var row = 1; row <= n; row++)
            {
                for (var col = 1; col <= n - row; col++)
                    Console.Write(" ");
                Console.Write("*");
                for (var col = 1; col < row; col++)
                    Console.Write(" *");
                Console.WriteLine();
            }
               for (var row = 1; row <= n-1; row++)
            {
                for (var col = 1; col <= row-1; col++)
                    Console.Write(" ");

                
                    for (var col = 1; col <= n - row; col++)
                        Console.Write(" *");
                Console.WriteLine();

            }

        }
    }
}
