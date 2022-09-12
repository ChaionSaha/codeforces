using System;

namespace _1180_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int sadik = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 0; i < sadik; i++)
            {
                sum = sum + (i * 4);
            }

            Console.WriteLine(sum);
        }
    }
}
