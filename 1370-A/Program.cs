using System;
using System.Collections.Generic;

namespace _1370_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> add = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int count = int.Parse(Console.ReadLine());
                for (int j = 1; j <= count-1; j++)
                {
                    for (int k = j+1; k <= count; k++)
                    {
                        add.Add(gcd(j, k));
                    }
                }
                add.Sort();
                add.Reverse();

                Console.WriteLine(add[0]);
                add.Clear();
            }

            
        }

        public static int gcd(int x, int y)
        {
            int temp = 1, gc=1;
            //bool loop = true;
            

            while(temp <= x && temp <= y)
            {
                if(x % temp==0 && y % temp==0)
                {
                    gc = temp;
                    ++temp;
                }
                else
                {
                    ++temp;
                }
            }

            return gc;

        }
    }
}
