namespace _1722A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            char[] word = "Timur".ToCharArray();

            for (int i = 0; i < loop; i++)
            {
                int letterCount = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                char[] inputToLetter = input.ToCharArray();
                
                bool isTimur=true;
                HashSet<char> output = new HashSet<char>();
                for (int j = 0; j < inputToLetter.Length; j++)
                {
                    output.Add(inputToLetter[j]);
                }
                Console.WriteLine(string.Join(' ', output));
                /*if(letterCount == 5)
                {
                    for (int k = 0; k < output.Count; k++)
                    {
                        if (!output.Contains(word[i]))
                        {
                            isTimur = false;
                        }
                    }
                    if(isTimur)
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
                }*/
            }
        }
    }
}