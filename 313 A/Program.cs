using System;

namespace _313_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int account = Convert.ToInt32(Console.ReadLine());
            int absValue = Math.Abs(account);
            string input = absValue.ToString();
            int numberOne, numberTwo;

            if (account > 0)
            {
                Console.WriteLine(account);
            }
            else
            {
                numberOne = int.Parse(input.Remove(input.Length - 1)) * -1;
                input = absValue.ToString();
                numberTwo = int.Parse(input.Remove(input.Length - 2, 1)) * -1;
                
                if (numberOne > numberTwo)
                {
                    Console.WriteLine($"{numberOne}");
                }
                else
                {
                    Console.WriteLine($"{numberTwo}");
                }
            }

        }
    }
}
