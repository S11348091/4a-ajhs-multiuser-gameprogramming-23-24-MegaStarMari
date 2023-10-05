// See https://aka.ms/new-console-template for more information
//02_Collections, Amarion Burks, v0.1c


using System;

namespace UpdateForEachProgram
{
    class UpdateForEachProgram
    {
        static void Main(string[] args)
        {
            // Collections are variables that can store multiple values in one variable

            /* Arrays
            -- Number of elements in an array CANNOT change
            -- Contents of elements in an array CAN change
            -- Items in the array are called ELEMENTS
            -- Arrays are ordered, each item has a fixed position
            -- The position is known as the INDEX
            -- First element in an array is index 0
            */

            // Declaring and Defining an Array
            string[] breakfastFoods = {"Bacon", "Waffles", "Pancakes", "Cereal", "Parfait"};
            int[] testScores = {95, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f, 2.25f, 1.74f, 1.99f, 0.99f, 4.25f};

            // Print all elements on single line
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScore: \n" + String.Join(", ", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(", ", GPA));
            Console.WriteLine();

            // Print each elements on seperate lines
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(",\n", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScore: \n" + String.Join(",\n", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(",\n", GPA));
            Console.WriteLine();




        }
    }
}