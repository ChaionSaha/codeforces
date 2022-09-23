namespace _1619_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string input = Console.ReadLine();
                List<char> list1 = new List<char>();
                List<char> list2 = new List<char>();
                string str1, str2;

                if(input.Length%2==0)
                {
                    int halfLength = input.Length/2;
                    for (int j = 0; j < halfLength; j++)
                    {
                        list1.Add(input[j]);
                    }
                    for(int j = halfLength; j < input.Length; j++)
                    {
                        list2.Add(input[j]);
                    }

                    str1 = String.Join("", list1);
                    str2 = String.Join("", list2);
                    if(str1.Equals(str2))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}