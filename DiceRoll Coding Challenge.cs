using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceRoll_Coding_Challenge
{

    class Program
    {

        static void Main(string[] args)
        // --> This program is a simple game wherein the two users/players "roll" a fair-sided
        //   dice and are assigned a value from 1 to 6.  Whoever finishes with the highest score
        //   wins, and if the program finishes with a draw then the "roll" can be repeated.
        {

            // --> Starting a new 'Random' type of variable
            Random rnd = new Random();

            // --> Allowing the users to enter their names in the form of strings.
            Console.WriteLine("Enter Player One name: ");
            string sP1_Name = Console.ReadLine();
            Console.WriteLine("Enter Player Two name: ");
            string sP2_Name = Console.ReadLine();



                            // PLAYER ONE'S TURN

            // --> The program uses the 'Random' variable "rnd" to create a number
            //   from the range of 1 and 7 (not including the upper limit) for Player 1.
            // --> The program then converts the number to a valid integer form so that
            //   a comparison of magnitude can later be completed to find the winner.
            Console.WriteLine();
            int rP1_Roll = rnd.Next(1, 7);
            int iP1_Roll = Convert.ToInt16(rP1_Roll);

            // --> The program now tells Player 1 what they have rolled by reusing
            //     variables from the last two stages of the code.
            // --> I've used a function of the C# Language within Visual Studio to
            //     create a suspenseful delay before finding out the score rolled.
            Console.WriteLine();
            Console.Write( sP1_Name + " rolled a ");
            System.Threading.Thread.Sleep(500);
            Console.Write(iP1_Roll);
            Console.WriteLine();



                            // PLAYER TWO'S TURN

            // --> The program  uses the 'Random' variable "rnd" to create a number
            //   from the range of 1 and 7 (not including the upper limit) for Player 2.
            // --> The program then converts the number to a valid integer form so that
            //   a comparison of magnitude can later be completed to find the winner. 
            Console.WriteLine();
            int rP2_Roll = rnd.Next(1, 7);
            int iP2_Roll = Convert.ToInt16(rP2_Roll);

            // --> The program now tells Player 2 what they have rolled by reusing
            //   variables from the last two stages of the code.
            // --> I've used a function of the C# Language within Visual Studio to
            //   create a suspenseful delay before finding out the score rolled.
            Console.WriteLine();
            Console.Write(sP2_Name + " rolled a ");
            System.Threading.Thread.Sleep(500);
            Console.Write(iP2_Roll);
            Console.WriteLine();



                            // FINDING THE WINNER

            // --> Here I've again used the "System.Threading.Thread.Sleep" function of
            //   to create suspense before finding out the winner or if it was a draw.
            Console.WriteLine();
            System.Threading.Thread.Sleep(750);

            if (iP1_Roll > iP2_Roll)
            {
                // --> This portion announces if Player 1 won.
                Console.WriteLine();
                Console.WriteLine("" + sP1_Name + " wins by beating " + sP2_Name + "'s "+ iP2_Roll +" with a " + iP1_Roll + "");
            }

            else if (iP2_Roll > iP1_Roll)
            {
                // --> This portion announces if Player 2 won.
                Console.WriteLine();
                Console.WriteLine("" + sP2_Name + " wins by beating " + sP1_Name + "'s "+ iP1_Roll +" with a " + iP2_Roll + "");
            }

            else if (iP1_Roll == iP2_Roll)
            {
                // --> This portion announces if neither player won the game
                //   (hence, if the scores were the same and it was a draw.)
                Console.WriteLine();
                Console.WriteLine("" + sP1_Name + " and " + sP2_Name + " have the same score (" + iP1_Roll + ") so it is a draw");
            }

            else
            {
                // --> Failsafe portion just in case I didn't write the code
                //   properly and there is a bug/error.  This can help me to
                //   find where a problem may reside.
                Console.WriteLine();
                Console.WriteLine("Error / Unexpected-Glitch");
            }

            // --> Ending to the program and allowing the user to quit when ready.
            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to finish");
            Console.ReadLine();
        }
    }
}
