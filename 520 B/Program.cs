namespace _520_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            bool isContinue = true, isAdd = true;
            int count=0;

            while(isContinue)
            {
                if(m<n)
                {
                    count = count + (n - m);
                    isContinue = false;
                }
                else if (n == m)
                {
                    count++;
                    isContinue = false;
                }
                else
                {
                    n = n * 2;
                    if (isAdd)
                        isAdd = false;

                    else
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}