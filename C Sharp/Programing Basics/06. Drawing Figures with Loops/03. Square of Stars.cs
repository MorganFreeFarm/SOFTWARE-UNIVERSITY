using System;

namespace P3.Square_of_Stars
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int j = 1; j < n; j++)
                {
                    Console.Write(" *");

                }
                Console.WriteLine();
            }
        }
    }
}
