using System;
using System.Collections.Generic;

namespace _1343_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                int arrayLength = int.Parse(Console.ReadLine());
                List<int> evenNumbers = new List<int>();
                List<int> oddNumbers = new List<int>();
                int sumOfEvenNumbers = 0, sumOfOddNumbers = 1, k = 0;

                oddNumbers.Add(1);





                if ((arrayLength / 2) % 2 !=0)
                {
                    Console.WriteLine("NO");
                }


                else
                {
                    for (int j = 0; j < arrayLength / 2; j++)
                    {
                        evenNumbers.Add((j * 2) + 2);
                        sumOfEvenNumbers = sumOfEvenNumbers + evenNumbers[j];
                    }

                    for (int j = 0; ; j++)
                    {
                        //sumOfEvenNumbers = sumOfEvenNumbers - sumOfOddNumbers;
                        for (int l = 1; l < ( arrayLength / 2 ) - 1; l++)
                        {
                            oddNumbers.Add(oddNumbers[k] + 2);
                            sumOfOddNumbers = sumOfOddNumbers + oddNumbers[l];
                            k++;
                        }

                        oddNumbers.Add(sumOfEvenNumbers - sumOfOddNumbers);
                        break;
                    }


                    Console.WriteLine("YES");

                    Console.WriteLine(string.Join(' ', evenNumbers) + " " + string.Join(' ', oddNumbers));
                }


            }
        }
    }
}
