using System;
using System.Collections.Generic;

namespace _1360_A
{
    class Program
    {
        static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                string[] numbers = Console.ReadLine().Split();

                List<double> a = new List<double>();

                a.Add(double.Parse(numbers[0]));
                a.Add(double.Parse(numbers[1]));

                a.Sort();

                if (Math.Pow(a[1], 2) > 2 * a[0] * a[1])
                {
                    Console.WriteLine(Math.Pow(a[1], 2));
                }


                else if (Math.Pow(a[0] * 2, 2) < 2 * a[0] * a[1])
                {
                    Console.WriteLine(Math.Pow(a[1] * 2, 2));
                }


                else
                {
                    Console.WriteLine(Math.Pow(a[0] * 2, 2));
                }




            }

        }
    }
}
