namespace _1426_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();

                int n = int.Parse(input[0]);
                int x = int.Parse(input[1]);

                int floorCount = 1, floor=2;
                bool isContinue = true;

                while(isContinue)
                {
                    if(n>0 && n<=2)
                    {
                        isContinue = false;
                        floorCount = 1;
                    }
                    else
                    {
                        floorCount++;
                        floor += x;
                        if(n>=floor-x && n<=floor)
                        {
                            isContinue = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                Console.WriteLine(floorCount);
            }
        }
    }
}