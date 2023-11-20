// Amarion Burks, Example Game Methods, v0.3
using System;

/*
Making FNAF in C#
Only making Bonnie
Bonnie has a difficulty of 1 - 20 chosen by user
Array of 7 rooms Bonnie can move to
If Bonnie is room 1, can attack is true unless door is closed
end game if Bonnie fails attack or if Bonnie succeeds attack
    player starts at 0 points, if bonnie succeeds attack, point goes to 0, if he fails, point goes to 2
Bonnie needs to roll 20 to move, any number below his difficulty lets him move
Bonnie randomly moves to an adjacent room (number)
Game takes place in turns, 60 turns (6 hours)
Door can be closed for 30 turns
*/




namespace ExampleGameMethods
{
    class ExampleGameMethods
    {
        static void Status(int statusID)
        {
            // Various lines for different parts of the game

            if (statusID==1){
                // Game info / Starting info
                Console.WriteLine("Welcome to Five Nights at Freddy's.");
                Console.WriteLine("You will be playing against Bonnie.");
                Console.WriteLine("You have 1 chance to block Bonnie's attack.");
                Console.WriteLine("Bonnie can move between 7 rooms, starting from 7 and preparing to attack at room 1.");
                Console.WriteLine("You will not know what room Bonnie is in currently in, only when he moves, and when he's nearby.");
                Console.WriteLine("");
            } else if (statusID==2){
                // Controls info
                Console.WriteLine("Your only commands are 'close door' and 'open door'.");
                Console.WriteLine("You can have your door closed until you run out of power (30 turns).");
            } else if (statusID==3){
                // Bonnie hasn't moved
                Console.WriteLine("Bonnie has not moved.");
            } else if (statusID==4){
                // Bonnie moved
                Console.WriteLine("Bonnie has moved.");
            } else if (statusID==5){
                // Bonnie current room
                Console.WriteLine("Bonnie is in room " + "");
            }

        }

        static bool Doors(string userInput)
        {
            bool doorClosed = false;

            if (userInput == "close door") {
                doorClosed = true;
            }
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

        static int Attack(bool canAttack, bool doorClosed, int lives)
        {
            if (canAttack == true && doorClosed == false){
                Console.WriteLine("Bonnie succeded an attack");
                lives--;
            } else if (canAttack == true && doorClosed == true) {
                Console.WriteLine("Bonnie failed an attack");
                lives++;
            }

            return lives;
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
            int lives = 0;

            curSpeed = 0;
            curRoom = 0;
            
            Status(1);

            Console.WriteLine("Please select a difficulty between 1 - 20");
            string userInput = Console.ReadLine();
            
            // put a while loop here to repeat until proper value chosen
            try {
                difficulty = Int32.Parse(userInput);
            } catch (Exception e) {
                Console.WriteLine("Non-numerical character detected, try again");
            }
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


            
        }
    }
}