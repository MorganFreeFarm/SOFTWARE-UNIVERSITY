using System;


namespace Ever_Or_Odd
{
    class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}

