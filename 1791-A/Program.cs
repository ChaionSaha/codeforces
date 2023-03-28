namespace _1791_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] word = "codeforces".ToCharArray();
            
            for (int i = 0; i < n; i++)
            {
                char a = Convert.ToChar( Console.ReadLine());
                //Console.WriteLine(word.Contains(a));
                if(word.Contains(a))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}