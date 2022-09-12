using System;

namespace _379_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int count = 0, rough = a;

            bool resume = true;


            while (resume)
            {
                if (((rough - b) + 1) > 0)
                {
                    rough = (rough - b) + 1;
                    count++;
                }

                else
                {
                    resume = false;
                }
            }

            Console.WriteLine(a + count);

        }
    }
}
