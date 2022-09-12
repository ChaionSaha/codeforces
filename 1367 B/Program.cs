using System;
using System.Collections.Generic;

namespace _1367_B
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
                int count = 0, rough = 0;

                foreach (var item in inputs)
                {
                    numbers.Add(int.Parse(item));
                }

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (j % 2 == numbers[j] % 2)
                    {
                        rough++;
                        continue;
                    }

                    else
                    {
                        if (numbers[j] %2 ==0)
                        {
                            count++;

                        }
                    }
                }


                if (rough == numbers.Count)
                {
                    Console.WriteLine(count);
                }
                
                else if (count == 0 || count % 2 != 0)
                {
                    Console.WriteLine("-1");
                }

                else
                {
                    Console.WriteLine(count / 2);
                }

            }
        }
    }
}
