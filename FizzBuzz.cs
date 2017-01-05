using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" This program will run through the numbers from 0 ");
            Console.WriteLine("  to 100 and will assign a string/word to numbers ");
            Console.WriteLine("              with certain factors.               ");
            Console.WriteLine();
            Console.WriteLine("   Try to see if you can work out these factors   ");
            Console.WriteLine();
            Console.WriteLine("            Press any key to continue.            ");
            Console.ReadKey();

            System.Threading.Thread.Sleep(85);
            Console.Clear();


            int Value = 0;
            System.Threading.Thread.Sleep(85);

            while (Value < 100)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Value = Value + 1;

                if (((Value % 5) == 0) && ((Value % 3) == 0 ))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta; // Combination colour
                    Console.WriteLine("FizzBuzz");  // For multiples of *both* 3 and 5
                    System.Threading.Thread.Sleep(175); // Short Delay between numbers
                }
                else if (Value % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Buzz");  // Just for multiples of 5
                    System.Threading.Thread.Sleep(175); // Short Delay between numbers
                }
                else if (Value % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fizz");  // Just for multiples of 3
                    System.Threading.Thread.Sleep(175); // Short Delay between numbers
                }
                else
                {
                    Console.WriteLine("" + Value + ""); // Simply output number
                    System.Threading.Thread.Sleep(175); // Short Delay between numbers
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            System.Threading.Thread.Sleep(220);
            Console.WriteLine();
            Console.WriteLine("Press any key to finish.");
            Console.ReadKey(); // Giving the user time to look at results before allowing them to quit when they choose
        }
    }
}
