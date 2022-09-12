namespace _148_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            int d = int.Parse(Console.ReadLine());
            if (numbers.Contains(1))
            {
                Console.WriteLine(d);
            }
            else
            {
                List<int> damagedDragon = new List<int>();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 1; j <= d; j++)
                    {
                        if (j % numbers[i] == 0 && !damagedDragon.Contains(j))
                        {
                            damagedDragon.Add(j);
                        }
                    }
                }
                Console.WriteLine($"{damagedDragon.Count}");
            }
        }
    }
}