using System;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            if (arr.Length == 1)
            {

                Console.WriteLine(arr[0]);


            }

            else {
                if (arr.Length % 2 == 0)
                {
                    Console.WriteLine(arr[(arr.Length / 2) - 1] + " " + arr[(arr.Length / 2)]);
                }

                else
                {
                    Console.WriteLine(arr[(arr.Length / 2) - 1] + " " + arr[arr.Length / 2] + " " + arr[(arr.Length / 2) + 1]);
                }
            }



        }

    }

}
