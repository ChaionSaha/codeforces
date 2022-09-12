using System;

namespace _1343_a
{
    class Program
    {
        static void Main()
        {
            int loop = int.Parse(Console.ReadLine());

            double sum = 0;
            double number = 0, div = 0, count = 0;

            for (int i = 0; i < loop; i++)
            {
                number = double.Parse(Console.ReadLine());
                sum = 1;
                div = 0;

                //if (IsPrime(number))
                //    div = number;

                //else
                //{
                    for (int j = 1; ; j++)
                    {
                        sum = sum + Math.Pow(2, j);
                        div = number / sum;
                        if (number % sum == 0)
                        {
                            //count++;
                            break;
                        }
                        else
                        {
                            div = 0;
                            //sum = 0;
                            continue;
                        }
                    }
                
                //}
                Console.WriteLine(div);
                
            }
        }

        //static void Main()
        //{
        //    double number = double.Parse(Console.ReadLine());
        //    Console.WriteLine(IsPrime(number));
        //}


        static bool IsPrime(double number)
        {
            double count = 0;
            for (double i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    count++; 
                    break;
                }
            }
            if (count >= 1)
            {
                return false;
            }
            else
                return true;
        }
    }
}
