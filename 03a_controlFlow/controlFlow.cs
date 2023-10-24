// Amarion Burks, Control Flow, v0.5
using System;

namespace controlFlow
{
    class controlFlow
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string favColor = "Yellow";
            int luckynumber = -5;
            float myGPA = 7.34F;
            int myAge = 17;
            bool pineappleOnPizza = false;

            // if Statements -- Check for a single condition
            if (favColor == "Yellow") {
                Console.WriteLine("Yellow is peak");
            }

            if (myAge < 18) {
                Console.WriteLine("You are not legal");
            }

            // if - else Statements -- Check for a single condition, but has two actions
            if (myAge > 15) {
                Console.WriteLine("You are old enough to drive");
            } else {
                Console.WriteLine("You aren't old enough to drive");
            }

            // if -- else if -- else -- Checks multiple conditions
            if (myGPA == 4.0F) {
                Console.WriteLine("Congrats on straight A grades!");
            } else if (myGPA >= 3.0F) {
                Console.WriteLine("Congrats on making honor roll!");
            } else if (myGPA >= 2.0F) {
                Console.WriteLine("You are graduation ready!");
            } else {
                Console.WriteLine("You are a disgrace.");
            }

            // WHEN CHECKING NUMBER VALUES, START IF STATEMENT WITH HIGHST VALUE


            // Nesting if statements
            if (pineappleOnPizza == true) {
                Console.WriteLine("How old are you?");
                if (myAge > 60) {
                Console.WriteLine("You old.");
                } else {
                Console.WriteLine("Reasonable.");
                }
            } else {
                Console.WriteLine("Good.");
            }

            // for Loop -- Best for when you know # interations needed
            /*

                for (statement1; statement2; statement3) {
                Code for loop
            }
            statement1 is executed ONCE BEFORE the loop starts
            statement2 is a CONDITIONAL that is checked EVERYTIME BEFORE loop starts
            statement3 is executed EVERYTIME after the loop runs

            

            for (int i = 0; i < 101, i++) {
                Console.WriteLine("" + i);
            }

            for (int i = 100; i = 0, i--) {
                Console.WriteLine("" + i);
            }

            // Nested Loops
            // Outer Loop
            for (int i = 1; i <= 3, i++) {
                Console.WriteLine("Outer:" + i);

                for (int j = 1; j <= 3, j++) {
                Console.WriteLine("Inner:" + i);
                }
            }

            // while Loop -- Best used when # of interations needed is unknown
            int x = 0;
            while (x < 1000) {
                Console.WriteLine("" + x);
                x++;
            }
            */
            // Special Keywords
            // break will instantly exit a LOOP or IF/ELSE block
            
            // for (int i = 0; i < 101; i++) {
            //     Console.WriteLine("" + i);
            //     if (i == 50) {
            //         break;
            //     }
            // }

            // continue will SKIP the current iteration and then finish the loop
        
            for (int i = 0; i < 101; i++) {
                //skips 50 
                if (i == 50) {
                    continue;
                }
                Console.WriteLine("" + i);
            }
            

        }
    }
}