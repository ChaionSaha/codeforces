using System;
using System.Collections.Generic;

namespace _1512_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(test());
            }

        }

        public static int test()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();
            int index = 0;

            List<int> testNumbers = new List<int>();
            
            foreach (var item in numbers)
            {
                testNumbers.Add(int.Parse(item));
            }
            
            int flag = testNumbers[0];
            
            
            if (flag!=testNumbers[1])
            {
                if(testNumbers[1]==testNumbers[2])
                {
                    flag = testNumbers[1];
                }
                else
                {
                    flag = testNumbers[0];
                }
            }
            
            
            for (int i = 0; i < n; i++)
            {
                if(flag!=testNumbers[i])
                {
                    index = i + 1;
                    break;
                }
            }

            return index;
        }
    }
}
