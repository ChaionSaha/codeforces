using System;
using System.Collections.Generic;

namespace _1374_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            bool add = true;

            for (int j = 0; j < testCases; j++)
            {
                string[] numbers = Console.ReadLine().Split();
                int x = int.Parse(numbers[0]);
                int y = int.Parse(numbers[1]);
                int n = int.Parse(numbers[2]);
                int count1 = 0;

                if (x == 0)
                {
                    Console.WriteLine("0");
                    continue;
                }
                add = true;
                while(add)
                {
                    if (n % x == y)
                    {
                        Console.WriteLine(n);
                        break;
                    }
                    else
                    {
                        count1++;
                        n--;
                        if (n<=0)
                        {
                            add = false;
                        }
                    }
                }

                if (count1 != 0 && n <= 0)
                {
                    Console.WriteLine("0");

                }
                else
                    continue;
            }

        }
    }
}
