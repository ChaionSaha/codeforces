using System;

namespace _1560_A
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
            int a = 1;
            string str;
            
            for (int i = 1; i < n; i++)
            {
                a++;
                str = a.ToString();
                if(a%3==0 || str[str.Length-1]=='3')
                {
                    i--;
                }
            }

            return a;
        }
    }
}
