// Amarion Burks, Example Game Methods, v0.2
using System;

/*
Making FNAF in C#
Only making Bonnie
Bonnie has a difficulty of 1 - 20 chosen by user
Array of rooms Bonnie can move to
If Bonnie is room 1, can attack is true unless door is closed
end game if Bonnie fails attack or if Bonnie succeeds attack
    player starts at 0 points, if bonnie succeeds attack, point goes to 0, if he fails, point goes to 2
Bonnie needs to roll 20 to move, any number below his difficulty lets him move
Bonnie randomly moves to an adjacent room (number)
*/




namespace ExampleGameMethods
{
    class ExampleGameMethods
    {
        static void GameSet()
        {
        }

        static bool Doors(string userInput)
        {
            // if (userInput == "close door") {
            //     doorClosed = true;
            // }
            bool doorClosed = false;
            return doorClosed;
        }

        static int Roll(int min, int max)
        {
            int curNumber;
            Random rndNum = new Random();
            curNumber = rndNum.Next(min, max);
            Console.WriteLine(curNumber);

            return curNumber;
        }

        static void Attack()
        {

        }
        static void Main(string[] args)
        {
            // Set up all defaults for the game
            float curSpeed = 0;
            int difficulty = 0;
            int curRoom = 0;
            int[] ROOMS = {1, 2, 3, 4, 5, 6, 7};
            bool doorClosed = false;
            bool canAttack = false;

            curSpeed = 0;
            curRoom = 0;
            
            string userInput = Console.ReadLine();
            
            difficulty = Int32.Parse(userInput);
            Console.WriteLine("You have selected " + difficulty);

            if (difficulty > 20) {
                Console.WriteLine(difficulty + " is above the max difficulty of 20, setting difficulty to 20");
                difficulty = 20;
            } else if (difficulty <= 20) {
                if (difficulty >= 0) {
                    Console.WriteLine("Valid value");
                }
            } else {
                Console.WriteLine("No value detected, setting difficulty to 10");
                difficulty = 10;
            }
            Roll(0,20);

            
        }
    }
}