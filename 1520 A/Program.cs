using System;


namespace _1520_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int letterCount = int.Parse(Console.ReadLine());
                string word = Console.ReadLine();
                List<char> uniqueLetters = new List<char>();
                int flag=0;
                for (int j = 0; j < letterCount; j++)
                {
                    char temp = word[j];
                    if (j==0)
                    {
                        uniqueLetters.Add(temp);
                    }
                    else
                    {
                        if(uniqueLetters.Contains(temp) && temp != word[j-1])
                        {
                            //Console.WriteLine("NO");
                            flag++;
                            break;
                        }
                        else if(!uniqueLetters.Contains(temp))
                        {
                            uniqueLetters.Add(temp);
                        }
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}