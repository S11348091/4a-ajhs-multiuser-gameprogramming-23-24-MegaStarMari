// Amarion Burks, Methods Parameters, v0.3
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD: named block of code, can be used repeatedly
        // ALL methods have a SIGNATURE that defines its name, parameters, and output
        // Example Signature
        static void MyMethod()
        {
            Console.WriteLine("I like chicken nuggets");
        }
        // static: This method belongs to the current class, is NOT an object
        // void: This method has no return value
        // method that doesnt have "void" MUST end with "return:"
        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.");
            Console.WriteLine("Please enter a number on the next line.");
            sum = System.Convert.ToInt32(Console.ReadLine());
            
            // Can use either
            //sum = sum * 2;
            //sum *= 2;
            //sum = sum + sum;
            //sum += sum;

            sum *= 2;
            Console.WriteLine(sum);

            // Can also do math in return
            // return sum *= 2;
            return sum;
        }

        static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Your pancake is on the way");
            }
        }

        static void MakeEggs(int num, string style)
        {
            Console.WriteLine( num + " eggs cooked " + style + " on the way!");
        }


        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes(1);
            MakeEggs(3, "scrambled light");
        }
    }
}