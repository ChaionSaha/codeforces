using System.Net.Http.Headers;

namespace _1520_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = int.Parse(Console.ReadLine());
                int ordinaryNumberCount = 0;

                for (int i = 1; i <= n; i++)
                {
                    if(ordinaryNumber(i))
                        ordinaryNumberCount++;
                }

                Console.WriteLine(ordinaryNumberCount);
            }
        }

        static bool ordinaryNumber(int n)
        {
            string numString = n.ToString();
            char[] charArr = numString.ToCharArray();
            Array.Reverse(charArr);
            string numStringRev = new string(charArr);

            if (numString.Equals(numStringRev))
                return true;
            else
                return false;
        }

       /* static string strRev(string a)
        {
            
        }*/
    }
}