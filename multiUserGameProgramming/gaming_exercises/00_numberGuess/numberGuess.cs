// Amarion Burks, Number Guess, v0.5

/* 
generate random number
define number range
tell user the range and number of guesses
user guess
if user guess is more or less, tell if more or less

MATCH == first player to score 3 points
ROUND == guessing a specific number until correct or no more guesses

for difficulty, can change # of guesses or number range
*/











using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int userGuess = 0;
            int numGuesses = 3;
            int numAttempts = 0;
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int curNumber = 0;
            int rangeMin = -1;
            int rangeMax = 100;

            Console.WriteLine("");
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("Please select your difficulty\nEasy Mode: Range is 0 - 10 with 4 guesses. \nNormal Mode: Range is 0 - 25 with 4 guesses. \nHard Mode: Range is 0 - 50 with 3 guesses.");

            difficulty = Console.ReadLine();
            Console.WriteLine("You have selected " + difficulty);

            if (difficulty == "easy") {
                numGuesses = 4;
                rangeMin = 0;
                rangeMax = 10;
            } else if (difficulty == "normal") {
                numGuesses = 4;
                rangeMin = 0;
                rangeMax = 25;
            } else if (difficulty == "hard") {
                numGuesses = 3;
                rangeMin = 0;
                rangeMax = 100;
            
            } else if (difficulty == "ERECT") {
                numGuesses = 20;
                rangeMin = 0;
                rangeMax = 500;
            
            } else {
                //if nothing else selected
                Console.WriteLine(difficulty + "is not a valid difficulty, selecting Easy Mode.");
                numGuesses = 4;
                rangeMin = 0;
                rangeMax = 10;
            }
            // Tell player min, max, and guesses

            while (playerScore != 3 && cpuScore != 3) {
                // Any code to run BEFORE each round goes here
                // Generate secret #
                Random rndNum = new Random();
                curNumber = rndNum.Next(rangeMin, rangeMax);
                Console.WriteLine(curNumber); //REMOVE AFTER TESTING
                Console.Write("Player Score: " + playerScore + ", CPU Score: " + cpuScore + "\n");

                //START EACH ROUND
                for (int i = 0; i < numGuesses; i++) {
                    // Code to guess number goes here
                    Console.WriteLine("You have used " + numAttempts + " attempts this round");
                    Console.WriteLine("Select a number between " + rangeMin + " and " + rangeMax + "\nYou have " + numGuesses + " max guesses.");
                    userGuess = System.Convert.ToInt32(Console.ReadLine());
                    if (userGuess == curNumber) {
                        Console.WriteLine("You got it right! You get 1 point!");
                        playerScore++;
                        numAttempts = 0;
                        break;
                    } else {
                        if (userGuess > curNumber) {
                            Console.WriteLine("Your guess is too high!\n");
                        } else {
                            Console.WriteLine("Your guess is too low!\n");
                        }   
                    }
                    numAttempts++;
                }
                if (userGuess != curNumber) {
                    cpuScore++;
                    numAttempts = 0;
                    Console.WriteLine("You lost! CPU gets a point!");
                }                

            }

            if (playerScore >= 3) {
                Console.WriteLine("You won the game!\n");
            } else {
                Console.WriteLine("You lost the game!\n");

            }

            




            // if (userInput == curNumber) {
            //     Console.WriteLine("You got it right! You earned a point!");
            //     playerScore++;
            // } else {
            //     cpuScore++;
            //     if (numAttempts != numGuesses) {
            //     Console.WriteLine("You got it wrong.. You get 2 more tries");
            //     if (userInput > curNumber) {
            //         Console.WriteLine("Your guess was too large");
            //     } else if (userInput < curNumber) {
            //         Console.WriteLine("Your guess was too small");
            //     }
            //     } else {
            //         Console.WriteLine("You're out of guesses");
            //     }
            // }
        }
    }
}