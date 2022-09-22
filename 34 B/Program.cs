namespace _34_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            int n = int.Parse(input1[0]);
            int m = int.Parse(input1[1]);

            List<int> amountOfTv = new List<int>();
            List<int> maxTv = new List<int>();

            for (int i = 0; i < input2.Length; i++)
            {
                amountOfTv.Add(int.Parse(input2[i]));
            }

            amountOfTv.Sort();

            for (int i = 0; i < m; i++)
            {
                maxTv.Add(amountOfTv[i]);
                if (maxTv[i] > 0)
                    maxTv[i] = 0;
            }

            int sum = -1 * maxTv.Sum();

            Console.WriteLine(sum);
        }
    }
}