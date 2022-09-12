using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("Enter the array of numbers separated by spaces:");
        string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        List<int> numbers = new List<int>();
        bool isTrue = false;

        foreach (var item in array)
        {
            numbers.Add(int.Parse(item));
        }

        int[] numbersArray = new int[numbers.Count];

        for (int i = 0; i < numbers.Count; i++)
        {
            numbersArray[i] = numbers[i];
        }

        Array.Sort(numbersArray);

        Console.WriteLine("\n");
        Console.WriteLine("The sorted array is:");
        foreach (var item in numbersArray)
        {
            Console.Write($"{item}\t");
        }

        Console.WriteLine("\n");
        int start = 0, end = numbersArray.Length - 1, midPoint = (start + end) / 2;
        Console.Write("Which number do you want to search: ");
        int numberToSearch = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");
        while (!isTrue)
        {
            Console.WriteLine($"Start point is: {start}, End point is: {end}, Mid point is: {midPoint}");
            if (numbersArray[midPoint] == numberToSearch)
            {
                isTrue = true;
            }
            else if (numbersArray[midPoint] < numberToSearch)
            {
                start = midPoint + 1;
            }
            else if (numbersArray[midPoint] > numberToSearch)
            {
                end = midPoint - 1;
            }

            midPoint = (start + end) / 2;
        }

        Console.WriteLine($"\n\nThe index of the number {numberToSearch} is: {midPoint + 1 }");


    }
}

