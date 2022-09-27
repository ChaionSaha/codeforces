namespace _1454_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = int.Parse(Console.ReadLine());
                List<int> number = new List<int>();

                for (int i = 1; i <=n; i++)
                {
                    number.Add(i);
                }

                Random random = new Random();
                number = number.OrderBy(x =>random.Next()).ToList();
                Console.WriteLine(String.Join(" ", number));
            }
        }
    }
}