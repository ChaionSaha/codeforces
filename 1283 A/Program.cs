namespace _1283_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                int h = int.Parse(input[0]);
                int m = int.Parse(input[1]);

                Console.WriteLine($"{((24 - h - 1) * 60) + (60 - m)}");
            }
        }
    }
}