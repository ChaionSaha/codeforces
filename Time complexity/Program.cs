using System;

namespace Time_complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {

                        count++;
                    }
                }
            }



            Console.WriteLine(count);

        }
    }
}
