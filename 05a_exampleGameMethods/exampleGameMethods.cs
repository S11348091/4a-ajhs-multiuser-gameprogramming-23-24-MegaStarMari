// Amarion Burks, Example Game Methods, v0.5
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
        static void Status(int statusID, int reqVar = 0)
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
                Console.WriteLine("Bonnie is in room " + reqVar);
            }

        }

        static bool Doors()
        {
            // Close and open doors
            Console.WriteLine("Input your command.");
            
            
            bool checking = true;
            bool doorClosed = false;
            string userInput = Console.ReadLine();
            
            // Loop until valid command is entered
            while (checking == true){
            if (userInput == "close door" || userInput == "close") {
                Console.WriteLine("Door has closed.\n");
                doorClosed = true;
                break;
            } else if (userInput == "open door" || userInput == "open") {
                Console.WriteLine("Door has opened.\n");
                doorClosed = false;
                break;
            } else {
                Console.WriteLine(userInput + " is not a valid command, try again");
                userInput = Console.ReadLine();
            }
            }

            return doorClosed;
        }

        static int Roll(int min=0, int max=20)
        {
            // Random number using min and max
            int curNumber;
            Random rndNum = new Random();
            curNumber = rndNum.Next(min, max);
            Console.WriteLine(curNumber);

            return curNumber;
        }

        static int Attack(bool canAttack, bool doorClosed, int lives)
        {
            // Various checks for Bonnies attack
            /* Can use the Doors method to meet the criteria:
            "At least one method should require output from another method to execute."
            */
            //If Bonnie is ready and door is open, attack and take 1 life
            if (canAttack == true && doorClosed == false){
                Console.WriteLine("Bonnie succeded an attack");
                lives--;
                Console.WriteLine("You have " + lives + " lives left");
            } else if (canAttack == true && doorClosed == true) {
                Console.WriteLine("Bonnie failed an attack");
            //If Bonnie isn't ready at all
            } else if (canAttack == false) {
                Console.WriteLine("Bonnie is unable to attack");
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
            curRoom = 5;



            //Testing all the methods
            Status(1);

            Console.WriteLine("Rooms:");
            for (int i = 0; i < ROOMS.Length; i++) {
                Console.WriteLine(ROOMS[i]);
            }
            
            Status(2);
            Status(3);
            Status(4);
            Status(5, curRoom);

            Roll();
            Roll(0,1);
            Roll(1900,2000);

            Attack(true, Doors(), 3);
            Console.WriteLine("");
            Attack(true, true, 4);
            Attack(true, false, 5);
            Attack(false, false, 2);
            Console.WriteLine("");

            Doors();




            //Realized we're just making the methods and not the game itself so canning this section for now (I miss python)

            /*
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
            */


            
        }
    }
}

// Amaure Cooper Code review
/*
I ran the code, there was zero errors
*/