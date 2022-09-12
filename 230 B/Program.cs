using System;
using System.Collections.Generic;

namespace _230_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] separatedNumbers = Console.ReadLine().Split();

            List<double> numbers = new List<double>();

            foreach (var item in separatedNumbers)
            {
                numbers.Add(double.Parse(item));
            }


            foreach (var item in numbers)
            {
                int count = 0, roughCount = 0;
                int rough = 0;
                List<int> divisors = new List<int>();
                
                
                for (double i = 1; i <= item; i++)
                {

                    if (item % i == 0)
                    {

                        rough = (int) (item / i);

                        foreach (var variable in divisors)
                        {
                            if (rough == variable)
                            {
                                count++;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (count == 0)
                        {
                            divisors.Add(rough);
                        }

                        //else if (count > 3)
                        //{
                        //    break;
                        //}
                    }
                }

                if (divisors.Count == 3)
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
}
