namespace _1692_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                List<int> distaces = new List<int>();
                int timur = int.Parse(numbers[0]);

                foreach (var item in numbers)
                {
                    distaces.Add(int.Parse(item));
                }

                distaces.Sort();
                distaces.Reverse();
                Console.WriteLine(distaces.IndexOf(timur));
            }
        }
    }
}