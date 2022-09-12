using System;
using System.Collections.Generic;
using System.Threading;

namespace Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            List<int> sortingNumbers = new List<int>();
            int proxy;
            foreach (var item in numbers)
            {
                sortingNumbers.Add(int.Parse(item));
            }

            for (int i = 1; i < sortingNumbers.Count; )
            {
                if (sortingNumbers[i] < sortingNumbers[i - 1] && i == 1)
                {
                    proxy = sortingNumbers[i - 1];
                    sortingNumbers[i - 1] = sortingNumbers[i];
                    sortingNumbers[i] = proxy;
                    i++;
                }
                
                else if (sortingNumbers[i] < sortingNumbers[i-1])
                {
                    proxy = sortingNumbers[i - 1];
                    sortingNumbers[i - 1] = sortingNumbers[i];
                    sortingNumbers[i] = proxy;
                    i--;
                }


                else
                {
                    i++;
                }

                Console.WriteLine(string.Join(" ", sortingNumbers));
                Console.WriteLine();
                Thread.Sleep(500);
            }


        }
    }
}
