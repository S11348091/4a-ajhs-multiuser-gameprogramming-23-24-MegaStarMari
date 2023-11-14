// Amarion Burks, Example Game Methods, v0.1
using System;

/*
Making FNAF in C#
Only making Bonnie
Bonnie has a difficulty of 1 - 20 chosen by user
Bonnie has a chance to move between 4 - 5 seconds, float
Array of rooms Bonnie can move to
If Bonnie is room 1, can attack is true unless door is closed
end game if Bonnie fails attack 5 times (or two minutes) or if Bonnie succeeds attack
Bonnie needs to roll 20 to move, any number below his difficulty lets him move
Bonnie randomly moves to an adjacent room (number)
*/




namespace UpdateForEachProgram
{
    class UpdateForEachProgram
    {
        static void GameSet()
        {
            // Set up all defaults for the game
            float curSpeed = 0;
            int difficulty = 0;
            int curRoom = 0;
            int[] ROOMS = {1, 2, 3, 4, 5, 6, 7};
            bool doorClosed = false;
            bool canAttack = false;


            canAttack = false;
            doorClosed = false;
            curRoom = 7;

            string userDifficulty = Console.ReadLine();
            difficulty = Int32.Parse(userDifficulty);
            Console.WriteLine("You have selected " + difficulty);

            if (difficulty > 20) {
                Console.WriteLine(difficulty + "is above the max difficulty of 20, setting difficulty to 20");
                difficulty = 20;
            } else if (difficulty < 20) {
                if (difficulty > 0) {
                    pass;
                }
            } else {
                Console.WriteLine("No value detected, setting difficulty to 10");
                difficulty = 10;
            }
        }

        static void Method2()
        {

        }

        static void Method3()
        {

        }

        static void Attack()
        {

        }
        static void Main(string[] args)
        {
            GameSet();
        }
    }
}