namespace _1311_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] numbers = Console.ReadLine().Split();
                int a = int.Parse(numbers[0]);
                int b = int.Parse(numbers[1]);

                if (a == b)
                    Console.WriteLine("0");
                else if (a > b)
                {
                    int diff = a - b;
                    if (diff % 2 == 0)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("2");
                    }
                }

                else if (b > a)
                {
                    int diff = b - a;
                    if (diff % 2 != 0)
                        Console.WriteLine("1");
                    else
                        Console.WriteLine("2");
                }
            }
        }
    }
}