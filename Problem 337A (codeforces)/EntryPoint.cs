using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int puzzlesNumbers = int.Parse(numbers[1]);
        int students = int.Parse(numbers[0]);
        //int temp = 0;

        string[] puzzles = Console.ReadLine().Split();
        int[] puzzleSizes = new int[puzzlesNumbers];
        for (int i = 0; i < puzzles.Length; i++)
        {
            puzzleSizes[i] = int.Parse(puzzles[i]);
        }

        Array.Sort(puzzleSizes);

        int lowest = puzzleSizes[puzzleSizes.Length - 1] - puzzleSizes[0];
        //Console.WriteLine(string.Join("  ", puzzleSizes));
        
        List<int> differences = new List<int>();
        
        for (int i = 0; i + students - 1 < puzzleSizes.Length ; i++)
        {
            differences.Add(puzzleSizes[i + students - 1] - puzzleSizes[i]);
        }
        
        for (int i = 0; i < differences.Count; i++)
        {
            lowest = Math.Min(lowest, differences[i]);
        }
        Console.WriteLine(lowest);

    }
}

