namespace _706_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbersStr = Console.ReadLine().Split();
            //int[] priceOfBottles = new int[n];
            List<int> priceOfBottles = new List<int>();

            /*for (int i = 0; i < n; i++)
            {
                priceOfBottles[i] = int.Parse(numbersStr[i]);
            }*/

            foreach (var item in numbersStr)
            {
                priceOfBottles.Add(int.Parse(item));
            }

            int q = int.Parse(Console.ReadLine());
            //int count = 0;
            List<int> bottles = new List<int>();
            bool isContinue = true;
            while(isContinue)
            {
                int count = 0;
                int coin = int.Parse(Console.ReadLine());
                /*for (int j = 0; j < n; j++)
                {
                    if (coin >= priceOfBottles[j])
                    {
                        count++;
                    }
                }*/
                foreach (var item in priceOfBottles)
                {
                    if (coin >= item) count++;
                }

                //Console.WriteLine(count);
                bottles.Add(count);
                q--;
                if(q == 0) isContinue = false;
            }

            foreach (var item in bottles)
            {
                Console.WriteLine(item);
            }
        }
    }
}