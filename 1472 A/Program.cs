namespace _1472_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                string[] input = Console.ReadLine().Split();
                int w = int.Parse(input[0]);
                int h = int.Parse(input[1]);
                int n = int.Parse(input[2]), w1=w, h1=h;
                int count = 0;
                bool isContinue = true;
                while(isContinue)
                {
                    if(w % 2 == 0)
                    {
                        w = w / 2;
                        
                    }
                    else if(h % 2 == 0)
                    {
                        h = h / 2;
                        
                    }
                    else
                    {
                        isContinue=false;
                    }
                }
                count = (w1 * h1) / (w * h);
                //Console.WriteLine($"count={count}, n={n}");
                if(count>=n)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}