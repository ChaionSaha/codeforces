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

                if ((a + b + c + n) % 3 == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }
        }
    }
}
