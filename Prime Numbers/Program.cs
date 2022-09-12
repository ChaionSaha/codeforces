using System.Globalization;

namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Till which number you want the prime numbers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) count++; 
                }

                if (count == 0) Console.WriteLine(i);
                count = 0;
            }
        }
    }
}