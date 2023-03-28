namespace _279B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]), t = int.Parse(inputs[1]);
            inputs = Console.ReadLine().Split();
            
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(inputs[i]));
            }

            int sum = 0, count=0;

            for (int i = 0;i < n; i++)
            {
                if ((sum + list[i]) <= t)
                {
                    count++;
                    sum += list[i];
                }
            }
            Console.WriteLine(count);
        }
    }
}