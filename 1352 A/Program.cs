using System;
using System.Collections.Generic;

namespace _1352_A
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                int count = 0, rawNumber = 0;
                string number = Console.ReadLine();
                char[] numberArray = number.ToCharArray();
                List<int> numberList = new List<int>();
                int zeros = number.Length - 1;




                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j] == '0')
                    {
                        zeros--;
                        continue;

                    }

                    else
                    {
                        rawNumber = (int)Char.GetNumericValue(number[j]);
                        numberList.Add(rawNumber * (int) Math.Pow(10, (double)zeros));
                        zeros--;
                        count++;
                    }
                
                }

                Console.WriteLine(count);
                foreach (var item in numberList)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }



        }
    }
}
