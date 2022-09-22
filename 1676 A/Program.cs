using System.Diagnostics.CodeAnalysis;

namespace _1676_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string input = Console.ReadLine();
                int sum1 = 0, sum2 = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if(j>=0 && j<=2)
                    {
                        sum1 += int.Parse(input[j].ToString());
                    }
                    else if(j>2 && j<input.Length)
                    {
                        sum2 += int.Parse(input[j].ToString());
                    }
                }

                if(sum1==sum2)
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