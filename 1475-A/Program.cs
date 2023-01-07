using System;
using System.Collections.Generic;

namespace _1475_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Int64 number = Int64.Parse(Console.ReadLine());
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
        public static bool test(Int64 number)
        {
            bool temp = false;
            
            if(number%2!=0)
            {
                temp = true;
            }
            else
            {
                if((number & (number-1))!=0)
                {
                    temp=true;
                }
            }
            

            /*if(flag) temp = true;
            else temp = false;*/

            return temp;
        }
    }
}
