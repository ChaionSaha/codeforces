namespace _1760A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                List<int> list = new List<int>();
                for (int j = 0; j < input.Length; j++)
                {
                    list.Add(int.Parse(input[j]));  
                }

                list.Sort();
                Console.WriteLine(list[1]);
            }
        }
    }
}