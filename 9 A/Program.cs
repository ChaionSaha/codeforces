using System.Xml.Schema;

namespace _9_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            List<int> inputInNumbers = new List<int>();

            foreach (var item in inputs)
            {
                inputInNumbers.Add(int.Parse(item));
            }

            int max = inputInNumbers.Max();
            int min = inputInNumbers.Min();

            Console.WriteLine(irreducibleFormat(6, (6 - max + 1)));
            
        }

        static string irreducibleFormat(int max, int min)
        {
            if(max % min != 0)
            {
                if (max % 2 == 0 && min % 2 == 0)
                    return $"{min / 2}/{max / 2}";
                else if (max % 3 == 0 && min % 3 == 0)
                    return $"{min / 3}/{max / 3}";
                else
                    return $"{min}/{max}";
            }
            else
            {
                int n = max / ((max / min) * min);
                int a = min / min;
                int b = max / min;
                return $"{a}/{b}";
            }
        }
    }
}