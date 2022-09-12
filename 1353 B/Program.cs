namespace _1353_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopCount = int.Parse(Console.ReadLine());
            for (int loop = 0; loop < loopCount; loop++)
            {
                string[] numbers = Console.ReadLine().Split();
                int n = int.Parse(numbers[0]);
                int k = int.Parse(numbers[1]);
                bool isContinue;
                

                int[] a = new int[n];
                int[] b = new int[n];

                string[] aNumbersString = Console.ReadLine().Split();
                string[] bNumbersString = Console.ReadLine().Split();

                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(aNumbersString[i]);
                    b[i] = int.Parse(bNumbersString[i]);
                }

                //Console.WriteLine($"Sum of a: {a.Sum()}, Sum of b: {b.Sum()}");
                if (k <= 0)
                { 
                    isContinue = false;
                    Console.WriteLine($"{a.Sum()}");
                }
                else isContinue = true;
                while (isContinue)
                {
                    if (a.Min() >= b.Max())
                    {
                        Console.WriteLine(a.Sum());
                        isContinue = false;
                        break;
                    }
                    else
                    {
                        (a[Array.IndexOf(a, a.Min())], b[Array.IndexOf(b, b.Max())])=(b[Array.IndexOf(b, b.Max())], a[Array.IndexOf(a, a.Min())]);
                        k--;
                        if (k <= 0)
                        {
                            isContinue = false;
                            Console.WriteLine(a.Sum());
                        }
                        else continue;
                    }
                }

            }
        }
    }
}