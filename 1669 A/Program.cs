namespace _1669_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= 1399)
                {
                    Console.WriteLine($"Division 4");
                }
                else if (number >= 1400 && number <= 1599)
                {
                    Console.WriteLine($"Division 3");
                }
                else if (number >= 1600 && number <= 1899)
                {
                    Console.WriteLine($"Division 2");
                }
                else if (number >= 1900)
                {
                    Console.WriteLine($"Division 1");
                }
            }
        }
    }
}