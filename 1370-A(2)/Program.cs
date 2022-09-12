using System;

namespace _1370_A_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(newNumber/2);
            }
        }
    }
}
