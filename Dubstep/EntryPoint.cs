using System;

class EntryPoint
{
    static void Main()
    {
        string remix = Console.ReadLine();

        string words = "WUB";

        string[] separatedWords = remix.Split(words, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in separatedWords)
        {
            Console.WriteLine(word);
        }
    }
}

