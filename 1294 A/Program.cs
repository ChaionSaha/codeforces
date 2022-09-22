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
                List<int> coins = new List<int>();
                for (int j = 0; j < input.Length-1; j++)
                {
                    coins.Add(int.Parse(input[j]));
                }
                int n = int.Parse(input[3]);
                int max = coins.Max();

                coins.Remove(max);

                int total = (max - coins[0]) + (max- coins[1]);

                if((n-total) >= 0 && (n-total)%3==0)
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
