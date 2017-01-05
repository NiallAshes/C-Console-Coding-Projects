using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area_Calculator__Looped_
{

    class Program
    {

        static void Main(string[] args)
        {

            // --> Setting the loop control variable
            bool Finished = false;
            while (Finished == false)
            {

                System.Console.Clear();

                // --> Setting a loop for allowing restarts
                bool RestartLoopActive = true;
                while (RestartLoopActive == true)
                {

                    // --> Aspect of code to allow the user to quit at will from within this 'menu'
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine();
                    Console.WriteLine("Area calculation program, enter 'Q' (case sensetive) to finish");
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("Enter 'Radius' for working out the area of a Circle");
                    Console.WriteLine("Enter 'Quadrilateral' for working out the area of a Square or Rectangle");
                    Console.WriteLine("Enter 'Triangle' for working out the area of a Triangle");
                    Console.WriteLine();
                    string Answer = Console.ReadLine();
                    Console.WriteLine();


                    // --> Option to quit functions via a simple loop which the user opts to end
                    if (Answer == "Q")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Closing Program now...");
                        System.Threading.Thread.Sleep(575);
                        Finished = true;
                        return;
                    }


                    //  ______________________________________________________________________________________________________
                    // |                                                                                                      |
                    // |                                             NOTE:                                                    |
                    // |                                                                                                      |
                    // | As the user chooses which portion of the code to use, we can see how the different data types        |
                    // | can effectively prohibit the user - During this demonstration we can see that in a hierarchy of      |
                    // | accuracy, the floating point "Double" values used are the most useful while conversely the Integer   |
                    // | values are by far the least useful. The decimal values used are set somewhere in between, and hence  |
                    // | are of a medium effiency/usefulness (see end of code * ).                                            |
                    // |______________________________________________________________________________________________________|



                        // QUADRILATERAL...

                    // Shows the use of DECIMAL values and convesion to other types of data
                    else if (Answer == "Quadrilateral")
                    {
                        // --> Preemptively designating named variables and their value types
                        decimal dLengthQuad = 0;
                        decimal dWidthQuad = 0;
                        decimal dQuadrilateralArea;

                        // --> User enters a number for the length of the Quadrilateral as a string.
                        // --> Then the string value is converted to a double value so it can be used in calculations.
                        Console.WriteLine("Enter the length of the shape in meters");
                        string sLengthQuad = Console.ReadLine();
                        decimal.TryParse(sLengthQuad, out dLengthQuad);

                        // --> Failsafe option (Response to invalid input)
                        if (dLengthQuad == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid numerical Length value");
                            System.Threading.Thread.Sleep(750);
                            Console.WriteLine();
                            Console.WriteLine("Press the 'Enter' key to restart and re-try");
                            Console.ReadKey();
                            RestartLoopActive = false;
                            break;
                        }

                        // --> User enters a number for the width of the Quadrilateral as a string.
                        // --> Then the string value is converted to a decimal value so it can be used in calculations.
                        Console.WriteLine("Enter the width of the shape in meters");
                        string sWidthQuad = Console.ReadLine();
                        decimal.TryParse(sWidthQuad, out dWidthQuad);

                        // --> Failsafe option (Response to invalid input)
                        if (dWidthQuad == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid numerical Width value");
                            System.Threading.Thread.Sleep(750);
                            Console.WriteLine();
                            Console.WriteLine("Press the 'Enter' key to restart and re-try");
                            Console.ReadKey();
                            RestartLoopActive = false;
                            break;
                        }

                        // --> Here is the actual calculation for the area of a Quadrilateral.
                        dQuadrilateralArea = (dLengthQuad * dWidthQuad);

                        // --> The code then outputs the final answer and allows the user to restart back to the menu.
                        // --> This portion of the code only uses Decimals (for demonstration purposes) hence it can
                        // allow for relatively high accuracy & range, albeit less efficiently than a Double value.
                        Console.WriteLine("Area is " + dQuadrilateralArea.ToString() + " sq m");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(750);
                        Console.WriteLine("Press the 'Enter' key to restart loop");
                        Console.ReadLine();
                    }




                        // RADIUS...

                    // Shows the use of DOUBLE values and convesion to other types of data.
                    else if (Answer == "Radius")
                    {
                        // --> User enters number with up to 5 decimal places for the radius of the circle as a string.
                        Console.WriteLine("Enter the Radius of the Circle in meters (up to 5 decimal places)");
                        string sRadius = Console.ReadLine();

                        // --> Converts the string value to a double value so it can be used in calculations.
                        // --> Also provides a named value for Pi, to be used for multiplication.
                        double Pi = 3.14159;
                        double dRadius = 0;
                        double.TryParse(sRadius, out dRadius);

                        // --> Failsafe option (Response to invalid input)
                        if (dRadius == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid numerical Radius value");
                            System.Threading.Thread.Sleep(750);
                            Console.WriteLine();
                            Console.WriteLine("Press the 'Enter' key to restart and re-try");
                            Console.ReadKey();
                            RestartLoopActive = false;
                            break;
                        }

                        // --> Here is the actual calculation for the area of a circle.
                        // --> This is the easiest way for me to have done  " A = Pi*(r^2) "  in C# Console.
                        double CircleArea = ((Pi) * ((dRadius) * (dRadius)));

                        // --> Here I'm rounding the area to 5 decimal places again, to retain consistency - This stage, 
                        // however, is not necessary whatsoever and does admittedly reduces both accuracy and range.
                        // --> The code then outputs the final answer and allows the user to restart back to the menu.
                        // --> This portion of the code only uses Doubles (for demonstration purposes) hence it can
                        // provide accuracy proportional to the range (number of decimal places input) given by the user.
                        Console.WriteLine("Area is " + Math.Round(CircleArea, 5).ToString() + " sq m");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(750);
                        Console.WriteLine("Press the 'Enter' key to restart loop");
                        Console.ReadLine();
                    }




                        // TRIANGLE...

                    // --> Shows use of INTEGER values and conversion to other types of data.
                    else if (Answer == "Triangle")
                    {

                        // --> User enters a whole-number value for the Base of a Triangle as a string
                        Console.WriteLine("Enter the length of the Base of a Triangle in whole meters");
                        string sBaseTri = Console.ReadLine();
                        int iBaseTri = 0;
                        Int32.TryParse(sBaseTri, out iBaseTri);

                        // --> Failsafe option (Response to invalid input)
                        if (iBaseTri == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid integer Base Length value");
                            System.Threading.Thread.Sleep(750);
                            Console.WriteLine();
                            Console.WriteLine("Press the 'Enter' key to restart and re-try");
                            Console.ReadKey();
                            RestartLoopActive = false;
                            break;
                        }

                        // --> User enters a whole-number value for the Height of a Triangle as a string
                        Console.WriteLine("Enter the length of the Height of a Triangle in whole meters");
                        string sHeightTri = Console.ReadLine();
                        int iHeightTri = 0;
                        Int32.TryParse(sHeightTri, out iHeightTri);

                        // --> Failsafe option (Response to invalid input)
                        if (iHeightTri == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid integer Height value");
                            System.Threading.Thread.Sleep(750);
                            Console.WriteLine();
                            Console.WriteLine("Press the 'Enter' key to restart and re-try");
                            Console.ReadKey();
                            RestartLoopActive = false;
                            break;
                        }

                        // --> Converts the string values into integers (hence the need for be whole numbers).
                        // --> Also provides a named value for the integer of 2, to be used for division.
                        int iHalf = (2);

                        // --> In the below line, I could have just used the number 2 instead of "iHalf".
                        // --> I decided to use the named integer to help with my own identification of core
                        // coding components though.
                        // --> In this case, as this portion of the program uses Integers only (for demonstration
                        // purposes), I could not have multiplied by 0.5 for the intended same effect.
                        int TriangleArea = (iHeightTri * iBaseTri / iHalf);

                        // --> The code then outputs the final answer and allows the user to restart back to the menu.
                        // --> A fine example of how limited Integers are can be identified by simply entering the
                        // value of 1 for both the base and the height: the program is unable to divide the interger 1
                        // by the integer 2, so it can only output the number 0 (rounded down from 0.5)
                        Console.WriteLine("Area is " + TriangleArea.ToString() + " sq m");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(750);
                        Console.WriteLine("Press the 'Enter' key to restart loop");
                        Console.ReadLine();
                    }



                    // --> Failsafe for if the user enters an invalid input to the main menu...
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("  Invalid input entered.  ");
                        Console.WriteLine();
                        Console.WriteLine("    RESTARTING PROGRAM    ");
                        System.Threading.Thread.Sleep(575);
                    }


                    
                    System.Console.Clear();



                    // [* Compared to floating-point types, the "Decimal" value type has more precision and a smaller
                    // range, which makes it appropriate for financial and currency calculations (or other Base-10
                    // numbers  -  Conversely, advantages to using double (or float) instead of decimal values include
                    // it using less memory and being faster due to floating point math operations being natively
                    // supported by processors.]
                }
            }
        }
    }
}