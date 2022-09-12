using System;

namespace _1433_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(test(number));
            }
        }

        public static int test(int n)
        {
            int temp = n % 10;
            int count = 0, sum = 0;
            bool p= true;
            while(p)
            {
                if(n%10==0)
                {
                    p = false;
                    break;
                }
                else
                {
                    ++count;
                    n = n / 10;
                }
            }
            sum = (temp-1) * 10;

            for (int i = 1; i <= count; i++)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}
