using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        List<int> distances = new List<int>();
        int totalDistance = 0;

        foreach (var item in input)
        {
            distances.Add(int.Parse(item));
        }

        distances.Sort();
        int midPoint = distances[1];

        foreach (var item in distances)
        {
            totalDistance = totalDistance + Math.Abs(midPoint - item);
        }

        Console.WriteLine(totalDistance);
    }
}
