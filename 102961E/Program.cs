namespace _102961E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<int> inTime=new List<int>();
            List<int> outTime=new List<int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                inTime.Add(int.Parse(input[0]));
                outTime.Add(int.Parse(input[1]));
            }

            int maxInTime=inTime.Max(), count=0;

            for (int i = 0; i < n; i++)
            {
                if (outTime[i] > maxInTime)
                    count++;
            }

            Console.WriteLine(count);

        }
    }
}