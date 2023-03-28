namespace _492B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int l = int.Parse(input[1]);

            input = Console.ReadLine().Split();
            List<int> numbers = new List<int>();
            foreach (var item in input)
            {
                numbers.Add(int.Parse(item));
            }

            numbers.Sort();
            int diff = 0;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                int count = numbers[i + 1] - numbers[i];
                if (count > diff)
                    diff = count;
            }

            int radius = diff / 2;
            float result = (float)radius + (float)0.5;

            Console.WriteLine(result);
        }
    }
}