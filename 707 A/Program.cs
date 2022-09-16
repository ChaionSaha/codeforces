// See https://aka.ms/new-console-template for more information
namespace _707_A
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            int n = int.Parse(numbers[0]);
            bool colored = false;
            
            for (int i = 0; i < n; i++)
            {
                string[] colors = Console.ReadLine().Split();
                if(colors.Contains("C") || colors.Contains("M") || colors.Contains("Y"))
                {
                    colored = true;
                }
            }

            if(colored)
                Console.WriteLine("#Color");
            else
                Console.WriteLine("#Black&White");
        }
    }
}
