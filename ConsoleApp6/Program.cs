using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 200.93;
            int b = Convert.ToInt32(a);
            int c = (int)a; 
            Console.WriteLine($"After converting the number {a}, results: {b}");
            Console.WriteLine($"After parsing the number {a}, results: {c}");
        }
    }
}
