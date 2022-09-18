namespace _1535_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop= int.Parse(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                string[] input = Console.ReadLine().Split();
                int[] firstPair = { int.Parse(input[0]), int.Parse(input[1]) };
                int[] secondPair = { int.Parse(input[2]), int.Parse(input[3]) };
                int[] maxArray = { firstPair.Max(), secondPair.Max() };

                int[] numbers = new int[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    numbers[j] = int.Parse(input[j]);
                }

                Array.Sort(numbers);
                Array.Reverse(numbers);

                Array.Sort(maxArray);
                Array.Reverse(maxArray);

                //Console.WriteLine($"{string.Join(" ", numbers)}\n{string.Join(" ", maxArray)}");

                if (numbers[0] == maxArray[0] && numbers[1] == maxArray[1])
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}