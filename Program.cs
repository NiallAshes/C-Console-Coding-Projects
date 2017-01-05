
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinFlipProgrammingChallenge
{

    class Program
    {

        static void Main(string[] args)
        {

            // -->  This program counts up how many of each face of a coin were found after eleven 'flips'.
            
            // --> Defining all of the variables that will be used later.
            Random rnd = new Random();
            int CoinFlip = 0;
            int Loop = 0;
            int CountHeads = 0;
            int CountTails = 0;
            System.Threading.Thread.Sleep(200);

            // --> Telling the user the parameters of the program.
            Console.WriteLine();
            Console.WriteLine("The program will now flip a virtual coin 11 times using RNG*");
            // ^ It is assumed here that the user knows that the abbreviation of RNG means 'Random Number Generation'
            //  - this might be an oversight and without that knowledge the user may have difficulty understanding.
            Console.WriteLine("You will then be told how many of each face were found");
            Console.WriteLine();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);

            // --> Starting the iterative 'while' loop that the program runs through for the 11 tosses.
            while (Loop < 11)
            {
                
                // --> This function uses random number generation up to (but not including) a limit: in this case 2.
                // --> Hence, for each loop, the program generates a value of either 0 or 1 for Heads and Tails respectively.
                Random random = new Random();
                int randomInt = random.Next(0, 2);
                CoinFlip = randomInt;

                
                // --> Now, whenever a Head or Tail is found, a counter for each increases by 1 before the loop restarts
                // --> This occurs until the 'Loop' value (which increases by a single value after each loop runs
                //   through) goes from the value of 0 to 10, at which point it finishes.


                    // Resultant option if coin lands on its first face (Heads)
                if (CoinFlip == 0)
                {
                    Console.WriteLine("Coin-toss #" + (Loop + 1) + "  ==>   Heads");
                    CountHeads = CountHeads + 1;
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(375);
                }


                    // Resultant option if coin lands on its second face (Tails)
                else if (CoinFlip == 1)
                {
                    Console.WriteLine("Coin-toss #" + (Loop + 1) + "  ==>   Tails");
                    CountTails = CountTails + 1;
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(375);
                }


                    // This resultant option is a failsafe option just in case there is a runtime issue occuring
                else
                {
                    Console.WriteLine("Unexpected Error/Glitch");
                    Loop = 11;
                }

                // --> Here is the code that causes the loop to increase towards its limit of 11 (which it stops before).
                Loop = (Loop + 1);
            }

            // --> The finale of the program tells the user the number of each face found.
            // --> Afterwards it allows the user to quit the application by internal input.
            Console.WriteLine();
            Console.WriteLine();
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("" + CountHeads + " Heads were flipped");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("" + CountTails + " Tails were flipped");
            Console.WriteLine();
            Console.WriteLine("Press the 'Enter' key to finish and close the application");
            Console.ReadLine();
        }
    }
}
