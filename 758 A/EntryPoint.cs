using System;
using System.Collections.Generic;

namespace _758_A
{
    class EntryPoint
    {
        static void Main()
        {
            Console.ReadLine();
            string[] numbers = Console.ReadLine().Split();

            List<int> welfare = new List<int>();
            int total = 0;
            
            foreach (var item in numbers)
            {
                welfare.Add(int.Parse(item));
            }

            welfare.Sort();
            int maxWealth = welfare[welfare.Count - 1];

            foreach (var item in welfare)
            {
                total = total + Math.Abs(maxWealth - item);
            }

            Console.WriteLine(total);

        }
    }
}
