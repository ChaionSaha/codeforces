using System;
using System.Collections.Generic;

namespace _1360_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                Console.ReadLine();
                string[] inputs = Console.ReadLine().Split();

                List<int> numbers = new List<int>();
                List<int> differences = new List<int>();
                
                
                foreach (var item in inputs)
                {
                    numbers.Add(int.Parse(item));
                }

                numbers.Sort();

                for (int j = 0; j < numbers.Count; j++)
                {
                    for (int k = j + 1; k < numbers.Count; k++)
                    {
                        differences.Add(numbers[k] - numbers[j]);
                    }
                }
                
                differences.Sort();
                
                Console.WriteLine(differences[0]);



            }



        }
    }
}
