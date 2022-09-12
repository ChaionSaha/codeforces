namespace _1624_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopCount = int.Parse(Console.ReadLine());
            for (int loop = 0; loop < loopCount; loop++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] numArr = new int[n];

                string[] strArr = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    numArr[i] = int.Parse(strArr[i]);
                }

                Console.WriteLine($"{numArr.Max()-numArr.Min()}");
            }
        }
    }
}