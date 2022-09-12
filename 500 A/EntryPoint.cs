using System;
using System.Collections.Generic;

namespace _500_A
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            int cellToGo = int.Parse(firstInput[1]);
            int count = 0, sum = 0;

            List<int> cells = new List<int>();
            foreach (var item in secondInput)
            {
                cells.Add(int.Parse(item));
            }

            for (int i = 1; i < cells.Count;)
            {
                i = i + cells[i-1];

                if (cellToGo == 1)
                {
                    count++;
                    break;
                }
                else if (i == cellToGo)
                {
                    count++;
                    break;
                }
                else
                {
                    sum = 0;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


           
        }


    }
}
