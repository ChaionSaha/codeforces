using System;
using System.Collections.Generic;

namespace _490_A
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            string[] numbers = Console.ReadLine().Split();
            List<int> students = new List<int>();
            int[] count = { 0, 0, 0 };

            int count1 = 0, count2 = 0, count3 = 0;
            int random;

            foreach (var item in numbers)
            {
                random = int.Parse(item);
                
                students.Add(random);
                if (random == 1)
                {
                    count[0]++;
                }
                else if (random == 2)
                {
                    count[1]++;
                }
                else if (random == 3)
                {
                    count[2]++;
                }
            }

            Array.Sort(count);
            //Console.WriteLine(count[0]);

            if (count[0] == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(count[0]);
                for (int i = 0; i < count[0]; i++)
                {
                    count1 = students.IndexOf(1) + 1;
                    students[count1 - 1] = 0;

                    count2 = students.IndexOf(2) + 1;
                    students[count2 - 1] = 0;

                    count3 = students.IndexOf(3) + 1;
                    students[count3 - 1] = 0;

                    Console.WriteLine($"{count1} {count2} {count3}");

                }
            }

            
        }
    }
}
