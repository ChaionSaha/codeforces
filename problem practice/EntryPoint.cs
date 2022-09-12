using System;
using System.Collections.Generic;
using System.Linq;

class EntryPoint
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int number1 = int.Parse(numbers[0]);
        int number2 = int.Parse(numbers[1]);

        Console.WriteLine(number1 + "  " + number2);
    }
}

