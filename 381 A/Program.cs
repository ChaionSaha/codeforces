namespace _381_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numList = new List<int>();

            string[] numInput = Console.ReadLine().Split();
            foreach (var item in numInput)
            {
                numList.Add(int.Parse(item));
            }

            List<int> sereja = new List<int>();
            List<int> dima = new List<int>();
            //numList.RemoveAt(0);

            //Console.WriteLine($"{numList.Count}");

            for (int i = 0; i < n; i++)
            {
                int max;
                if (numList[0] > numList[numList.Count-1])
                {
                    max= numList[0];
                    numList.RemoveAt(0);
                    if(i%2==0)
                    {
                        sereja.Add(max);
                    }
                    else
                    {
                        dima.Add(max);
                    }
                }
                else //if(numList[0] < numList[numList.Count - 1])
                {
                    max = numList[numList.Count - 1];
                    numList.RemoveAt(numList.Count - 1);
                    if (i % 2 == 0)
                    {
                        sereja.Add(max);
                    }
                    else
                    {
                        dima.Add(max);
                    }
                }
            }

            Console.WriteLine($"{sereja.Sum()}\t{dima.Sum()}");
        }
    }
}