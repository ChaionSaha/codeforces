namespace _580_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();
            int[] numberSegment = new int[n];

            for (int i = 0; i < n; i++)
            {
                numberSegment[i] = int.Parse(numbers[i]);
            }
        }
    }
}