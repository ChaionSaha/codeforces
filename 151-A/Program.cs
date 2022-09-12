using System;
using System.Collections.Generic;

namespace _151_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            List<int> cookie = new List<int>();

            foreach (var item in numbers)
            {
                cookie.Add(int.Parse(item));
            }

            int drink = cookie[1] * cookie[2], lime = cookie[3] * cookie[4], salt = cookie[5] / cookie[7];
            int toast = drink / cookie[6];

            Console.WriteLine(Math.Min(Math.Min(toast, lime), salt) / cookie[0]);
        }
    }
}
