﻿namespace _1371_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                    Console.WriteLine($"{(number / 2) + 1}");
                else
                    Console.WriteLine($"{number / 2}");
            }
        }
    }
}