using System.Diagnostics.CodeAnalysis;

namespace _1294_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]), n = int.Parse(input[3]);

                if ((a < n && b < n && c < n) && (a + b + c + n) % 3 == 0)
                {
                    Console.WriteLine("YES");
                }

                else if(a==b && b==c && (float)n%3==0)
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    float avg = (a + b + c) / 3;
                    if(avg == (float)n/3)
                    {
                        Console.WriteLine("YES");
                    }
                    else if ((avg - a) + (avg - b) + (avg - c) == n)
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
}
