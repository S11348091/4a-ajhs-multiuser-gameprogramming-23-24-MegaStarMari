// Amarion Burks, Operators, v0.3
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create TWO Strings, Integers, and Floats
            string myStr1 = "bababoi";
            string myStr2 = "chicken";

            int myInt1 = 58;
            int myInt2 = 93;

            float myFlt1 = 3.14F;
            float myFlt2 = 4.20F;

            // Arithmetic Operators
            Console.WriteLine(myInt1 + myInt2);
            Console.WriteLine(myStr1 + myStr2);
            Console.WriteLine(myFlt1 + myFlt2);
            Console.WriteLine(myInt1 + myFlt2);

            // "*" "-" "/" Does not apply to strings
            Console.WriteLine(myInt1 * myInt2);
            //Console.WriteLine(myStr1 * myStr2);
            Console.WriteLine(myFlt1 * myFlt2);
            Console.WriteLine(myInt1 * myFlt2);

            Console.WriteLine(myInt1 - myInt2);
            //Console.WriteLine(myStr1 - myStr2);
            Console.WriteLine(myFlt1 - myFlt2);
            Console.WriteLine(myInt1 - myFlt2);

            Console.WriteLine(myInt1 / myInt2);
            //Console.WriteLine(myStr1 / myStr2);
            Console.WriteLine(myFlt1 / myFlt2);
            Console.WriteLine(myInt1 / myFlt2);

            // Modulus
            Console.WriteLine("Modulus");
            Console.WriteLine(10 % 2);
            Console.WriteLine(9 % 4);

            // Increment
            int myInt3 = 1;
            myInt3++;
            Console.WriteLine(myInt3);

            // Decrement
            int myInt4 = 2;
            myInt4--;
            Console.WriteLine(myInt4);

            // Assignments Operators
            // =
            int nTH1 = 100;
            int nTH2 = 50;
            // +=
            nTH1 += 25;
            // -=
            nTH1 -= nTH2;
            // *=
            nTH1 *= 2;
            // /=
            nTH2 /= 5;

            // Comparison Operatods
            // Is Equal To
            Console.WriteLine(3 == 4);
            // Greater Than
            Console.WriteLine(5 > 4);
            // Greater Than or Equal To
            Console.WriteLine(7 >= 7);
            // Less Than
            Console.WriteLine(8 < 3);
            // Less Than or Equal To
            Console.WriteLine(4 <= 6);
            // Not Equal To
            Console.WriteLine(8 != 0);

            // Logical Operators
            // And - ALL conditions must be TRUE
            Console.WriteLine(3 > 2 && 2 == 2); // True + True = True
            Console.WriteLine(3 > 2 && 5 > 6); // True + False = False
            // Or - ONE condition must be TRUE
            Console.WriteLine(5 < 9 || 5 != 4); // True or True = True
            Console.WriteLine(9 < 10 || 3 > 5); // True or False = True
            // Not - Find the OPPOSITE value
            Console.WriteLine(!(3 > 2)); // NOT True = False


        }
    }
}