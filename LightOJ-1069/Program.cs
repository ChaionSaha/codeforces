using System;

namespace LightOJ_1069
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= loops; i++)
            {
                string[] numbers = Console.ReadLine().Split();

                int floor = int.Parse(numbers[0]);
                int floorToGo = int.Parse(numbers[1]);
                int sum = 0;
                //if (floorToGo < floor)
                //    sum = floorToGo + floor;
                //else
                    sum = floorToGo;

                int time = 19 + (sum * 4);
                Console.WriteLine("Case " + i +": " + time);



            }
        }
    }
}
