using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudent = 40, boys = 30, girls = 10, gradeABoys=22, gradeAGirls, gradeAPercent=70;

            gradeAGirls = ((totalStudent * gradeAPercent) / 100) - gradeABoys;

            Console.WriteLine("Grade A girls: "+gradeAGirls);
        }
    }
}
