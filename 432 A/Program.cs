using System;
using System.Collections.Generic;

namespace _432_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();


            int count = 0, max = int.Parse(firstInput[1]);
            List<int> participationNumbers = new List<int>();

            foreach (var item in secondInput)
            {
                participationNumbers.Add(int.Parse(item));
            }

            foreach (var item in participationNumbers)
            {
                if (item + max <= 5)
                {
                    count++;
                }
            }

            Console.WriteLine(count/3);
        }
    }
}
