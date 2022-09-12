using System.Globalization;

namespace _136_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();
            int[] oldArray = new int[n];
            int[] newArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                oldArray[i] = int.Parse(numbers[i]);
            }
            for (int i = 0; i < n; i++)
            {
                newArray[oldArray[i] - 1] = i + 1;
            }
            Console.WriteLine(String.Join(' ', newArray));
        }
    }
}