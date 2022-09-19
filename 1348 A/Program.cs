namespace _1348_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                int n = int.Parse(Console.ReadLine());
                List<int> a = new List<int>();
                List<int> b = new List<int>();
                List<int> newArr = new List<int>();

                double sumArrA = 0, sumArrB = 0;
                bool isContinue = true, min = true, max = false;

                for (int j = 0; j < n; j++)
                {
                    newArr.Add(j + 1);
                }

                while(isContinue)
                {
                    if(newArr.Count==0)
                    {
                        isContinue = false;
                        break;
                    }
                    
                    if(min)
                    {
                        a.Add(newArr.Min());
                        newArr.Remove(newArr.Min());
                        b.Add(newArr.Min());
                        newArr.Remove(newArr.Min());
                        min = false;
                        max = true;
                    }

                    else if(max)
                    {
                        a.Add(newArr.Max());
                        newArr.Remove(newArr.Max());
                        b.Add(newArr.Max());
                        newArr.Remove(newArr.Max());
                        min = true;
                        max = false;
                    }
                }

                for(int j = 0; j < a.Count; j++)
                {
                    sumArrA += Math.Pow(2, (double)a[j]);
                    sumArrB += Math.Pow(2, (double)b[j]);
                }

                Console.WriteLine($"{Math.Abs(sumArrA-sumArrB)}");
            }
        }
    }
}