using System;
using System.Threading;
using WarriorWars.ColorFullMessage;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 10;
        private const int BAD_GUY_STARTING_HEALTH = 10;
        
        

        private readonly Faction FACTION;
        
        private Weapon weapon;
        private Armor armor;
        
        private string name;
        private int health;
        private bool isAlive;

        public bool IsAlive 
        {
            get
            {
                return isAlive;
            }
        }

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;



            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;

                    
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;


                default:
                    break;
            }


        }


        public void attack(Warrior enemy)
        {
            Random rng = new Random();
            int damage = rng.Next(1, 3);


            enemy.health = enemy.health - damage;


            if (enemy.health <= 0)
            {
                enemy.isAlive = false;

                string[] message = { $"{name} is victorious!!", $"{enemy.name} is dead!!" };

                

                for (int i = 0; i < message[0].Length; i++)
                {
                    Console.CursorVisible = true;
                    Tools.ColorfullMessage(message[0][i], ConsoleColor.Green);
                    Thread.Sleep(90);
                }

                Console.WriteLine();

                for (int i = 0; i < message[1].Length; i++)
                {
                    Console.CursorVisible = true;
                    Tools.ColorfullMessage(message[1][i], ConsoleColor.Red);
                    Thread.Sleep(90);
                }
                Console.CursorVisible = false;
                Console.WriteLine("\n\n\n");
            }

            else
            {
                Console.CursorVisible = false;
                Console.WriteLine($"{name} attacked {enemy.name} for {damage}.. \n{name} current health: {health}\n{enemy.name} current health: {enemy.health}\n");
                Console.WriteLine($"{new string('-', 50)}");
                Console.WriteLine($"{new string('-', 50)}\n");
            }
        }
    }
}
