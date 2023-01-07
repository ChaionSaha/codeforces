// See https://aka.ms/new-console-template for more information
using System;

namespace _489_B
{
    class Program
    {
        static void Main()
        {
            int numberOfBoys = int.Parse(Console.ReadLine());
            string[] boys = Console.ReadLine().Split();
            int numberOfGirls = int.Parse(Console.ReadLine());
            string[] girls = Console.ReadLine().Split();

            List<int> boysSkills = new List<int>();
            List<int> girlsSkills = new List<int>();
            int pair = 0;

            foreach (var item in boys)
            {
                boysSkills.Add(int.Parse(item));
            }

            foreach (var item in girls)
            {
                girlsSkills.Add(int.Parse(item));
            }

            boysSkills.Sort();
            girlsSkills.Sort();

            if(boysSkills.Count <= girlsSkills.Count)
            {
                foreach (var item in boysSkills)
                {
                    if(girlsSkills.Contains(item))
                    {
                        pair++;
                        girlsSkills.Remove(item);

                    }
                    else if(girlsSkills.Contains(item - 1))
                    {
                        pair++;
                        girlsSkills.Remove(item-1);
                    }
                    else if(girlsSkills.Contains(item + 1))
                    {
                        pair++;
                        girlsSkills.Remove(item + 1);
                    }
                }
            }
            else
            {
                foreach (var item in girlsSkills)
                {
                    if (boysSkills.Contains(item) /*|| boysSkills.Contains(item - 1) || boysSkills.Contains(item + 1)*/)
                    {
                        pair++;
                        boysSkills.Remove(item);
                    }
                    else if(boysSkills.Contains(item + 1))
                    {
                        boysSkills.Remove(item + 1);
                        pair++;
                    }
                    else if(boysSkills.Contains(item-1))
                    {
                        pair++;
                        boysSkills.Remove(item - 1);
                    }
                }
            }

            Console.WriteLine(pair);
        }
    }
}
