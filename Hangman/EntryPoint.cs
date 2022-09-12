using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        string[] messages = { @" __    __       ___      .__   __.   _______ .___  ___.      ___      .__   __.
|  |  |  |     /   \     |  \ |  |  /  _____||   \/   |     /   \     |  \ |  |
|  |__|  |    /  ^  \    |   \|  | |  |  __  |  \  /  |    /  ^  \    |   \|  |
|   __   |   /  /_\  \   |  . `  | |  | |_ | |  |\/|  |   /  /_\  \   |  . `  |
|  |  |  |  /  _____  \  |  |\   | |  |__| | |  |  |  |  /  _____  \  |  |\   |
|__|  |__| /__/     \__\ |__| \__|  \______| |__|  |__| /__/     \__\ |__| \__|
                                                                               
",@"  _______      ___      .___  ___.  _______      ______   ____    ____  _______ .______       __ 
 /  _____|    /   \     |   \/   | |   ____|    /  __  \  \   \  /   / |   ____||   _  \     |  |
|  |  __     /  ^  \    |  \  /  | |  |__      |  |  |  |  \   \/   /  |  |__   |  |_)  |    |  |
|  | |_ |   /  /_\  \   |  |\/|  | |   __|     |  |  |  |   \      /   |   __|  |      /     |  |
|  |__| |  /  _____  \  |  |  |  | |  |____    |  `--'  |    \    /    |  |____ |  |\  \----.|__|
 \______| /__/     \__\ |__|  |__| |_______|    \______/      \__/     |_______|| _| `._____|(__)
                                                                                                 ", @"____    ____  ______    __    __     ____    __    ____  __  .__   __.  __ 
\   \  /   / /  __  \  |  |  |  |    \   \  /  \  /   / |  | |  \ |  | |  |
 \   \/   / |  |  |  | |  |  |  |     \   \/    \/   /  |  | |   \|  | |  |
  \_    _/  |  |  |  | |  |  |  |      \            /   |  | |  . `  | |  |
    |  |    |  `--'  | |  `--'  |       \    /\    /    |  | |  |\   | |__|
    |__|     \______/   \______/         \__/  \__/     |__| |__| \__| (__)
                                                                           " };
        string[] counting = { @" __ 
/_ |
 | |
 | |
 | |
 |_|
    ", @" ___  
|__ \ 
   ) |
  / / 
 / /_ 
|____|", @" ____  
|___ \ 
  __) |
 |__ < 
 ___) |
|____/ 
       ", @" _  _   
| || |  
| || |_ 
|__   _|
   | |  
   |_|  ", @" _____ 
| ____|
| |__  
|___ \ 
 ___) |
|____/ " };

        bool gameOver = false;

        string startWord = "guess the word";
        int guessingTries = startWord.Length * 2;
        char[] maskWord = new string('-', startWord.Length).ToCharArray();
        string insertedKey = "";
        string characterList = "";
        int violations = 0;

        
        Console.CursorVisible = false;

        for (int i = counting.Length - 1; i >=0 ; i--)
        {
            Console.WriteLine(messages[0]);
            Console.WriteLine(counting[i]);
            Thread.Sleep(1000);
            Console.Clear();
        }


        while(!gameOver)
        {

            Console.Clear();

            Console.WriteLine("Guess the word: {0}", new string(maskWord));
            Console.WriteLine("Guessed characters: {0}", characterList);
            Console.WriteLine("You have {0} tries left.", guessingTries);
            Console.WriteLine();
            Console.Write("Your next guess is: ");
            
            
            insertedKey = Console.ReadLine();
            characterList += insertedKey[0] + ", ";

            if (insertedKey.Length > 1)
            {
                violations++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou have to input only ONE single character! ");
                Console.WriteLine("You will lose 2 tries for each following violation of the rule!");

                if (violations > 1)
                {
                    guessingTries--;
                }
                Thread.Sleep(3000);
                Console.ResetColor();
            }


            if (startWord.Contains(insertedKey[0]))
            {
                for (int i = 0; i < startWord.Length; i++)
                {
                    if (startWord[i] == Convert.ToChar(insertedKey[0]))
                    {
                        maskWord[i] = Convert.ToChar(insertedKey[0]);
                    }
                }
            }
            
            guessingTries--;
            if (guessingTries <= 0)
            {
                gameOver = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(messages[1]);
                Console.ResetColor();
            }
            else if(!(new string(maskWord).Contains("-")))
            {
                gameOver = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(messages[2]);
                Console.ResetColor();
            }
            
        }
    }
}

