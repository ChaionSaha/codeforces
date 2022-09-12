using System;
using System.Collections.Generic;

namespace _703_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int mishka, chris, countForMishka = 0, countForChris = 0;

            for (int i = 0; i < loops; i++)
            {
                string[] numbers = Console.ReadLine().Split();

                mishka = int.Parse(numbers[0]);
                chris = int.Parse(numbers[1]);

                if (mishka > chris)
                {
                    countForMishka++;
                }

                else if (chris > mishka)
                {
                    countForChris++;
                }




            }

            if (countForMishka > countForChris)
            {
                Console.WriteLine("Mishka");
            }

            else if (countForChris > countForMishka)
            {
                Console.WriteLine("Chris");
            }

            else
            {
                Console.WriteLine("Friendship is magic!^^");
            }




        }
    }
}
