namespace _1472_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            for (int loopCount = 0; loopCount < loop; loopCount++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] numArr = new int[n];
                string[] inpArr = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    numArr[i] = int.Parse(inpArr[i]);
                }

                if (allEqualArr(numArr) || twoEqualArr(numArr)) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }

            /*if(false || true || true)
                Console.WriteLine("It happens to be true");
            else
                Console.WriteLine("False");*/
        }

        static bool allEqualArr(int[] numArr)
        {
            int count = 0;
            for (int i = 0; i < numArr.Length-1; i++)
            {
                if (numArr[i] != numArr[i + 1])
                {
                    count++;
                }
            }
            if (count == 0 && numArr.Length % 2 == 0) return true;
            else return false;
        }

        static bool twoEqualArr(int[] numArr)
        {
            List<int> gram1 = new List<int>();
            List<int> gram2 = new List<int>();
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] == 1) gram1.Add(1);
                else gram2.Add(2);
            }

            if ((gram1.Count == gram2.Count && gram1.Sum()==gram2.Sum()) || (gram1.Count == gram2.Count && gram1.Count!=1) ) return true;
            else if(gram1.Sum() == gram2.Sum()) return true;
            else return false;
        }

    }
}