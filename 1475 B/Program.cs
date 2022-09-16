namespace _1475_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int year = int.Parse(Console.ReadLine());
                if(year >= 2020)
                {
                    if(leapYear(year) || leapYear(year-1) || leapYear(year-2))
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        static bool leapYear(int year)
        {
            if (year % 4 == 0)
                return true;
            else if (year % 100 == 0)
                return false;
            else if (year % 400 == 0)
                return true;
            else
                return false;
        }
    }
}