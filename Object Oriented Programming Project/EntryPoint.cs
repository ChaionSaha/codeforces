using System;
using System.Threading;
using WarriorWars;
using WarriorWars.Enum;

class EntryPoint
{
    static void Main()
    {
        Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
        Warrior badGuy = new Warrior("Joe", Faction.BadGuy);

        Random rng = new Random();

        //Console.CursorVisible = true;
        Console.Title = "WarriorWars";



        while (goodGuy.IsAlive && badGuy.IsAlive)
        {

            if (rng.Next(0, 10)<5)
            {
                goodGuy.attack(badGuy);
            }
            else
            {
                badGuy.attack(goodGuy);
            }
            Thread.Sleep(500);
        }


        Console.ReadKey();
    }
}

