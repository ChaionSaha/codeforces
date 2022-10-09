namespace _80_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]), nextPrime = 0, count = 0;

            for (int a0 = n + 1; ; a0++)
            {
                count = 0;
                for (int a1 = 2; a1 < a0; a1++)
                {
                    if (a0 % a1 == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    nextPrime = a0;
                    break;
                }
            }

            if (nextPrime == m)
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