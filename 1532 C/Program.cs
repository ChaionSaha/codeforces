namespace _1532_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                for (int j = 1; ; j++)
                {
                    if(j % n != 0)
                    {
                        k--;
                    }
                    if(k== 0)
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
    }
}