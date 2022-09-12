using System;

namespace _1475_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ulong number = ulong.Parse(Console.ReadLine());
                if (test(number))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        public static bool test(ulong number)
        {
            ulong count = 0;
            bool temp;
            if(number%2!=0)
            {
                temp = true;
            }

            else
            {
                count = number / 2;
                if (count % 2 != 0 && count > 1)
                    temp = true;
                else
                    temp = false;
            }

            return temp;
        }
    }
}
