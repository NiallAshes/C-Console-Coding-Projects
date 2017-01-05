using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime_Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            // The user enters a value as instructed to by the program
            Console.WriteLine("Prime number checker");
            Console.WriteLine("Enter a prime number to get checked");

            // Whatever the user enters is converted into integer (whole number)
            int iNumberToCheck = Convert.ToInt32(Console.ReadLine());

            // This integer value is assigned as a variable and is then ran through a function *
            int Result = Check_Prime(iNumberToCheck);



            // BELOW are the THREE output formats depending on what the function * returns

            if (Result == 0)
            {
                Console.WriteLine(iNumberToCheck + " is not a prime number.");
            }

            else if (Result != 0)
            {
                Console.WriteLine(iNumberToCheck + " is a prime number.");
            }

            else
            {
                Console.WriteLine("Unexpected error/glitch");
            }

            Console.ReadLine();
        }



        // Here is the afforementioned * function called "Check Prime" that, as
        //  the name suggests, is used to calculate if the entered number is
        //  only divisible by itself and 1 (i.e. they are the only factors)

        private static int Check_Prime(int iNumberToCheck)
        {
            // Checking if the supposed prime number has any factors from 2 to (n-1)
            int CountingUp;
            for (CountingUp = 2; CountingUp <= (iNumberToCheck - 1); CountingUp++)
            {
                if (iNumberToCheck % CountingUp == 0)
                {
                    return 0;
                }
            }
            if (CountingUp == iNumberToCheck)
            {
                return 1;
            }
            return 0;
        }
    }
}
