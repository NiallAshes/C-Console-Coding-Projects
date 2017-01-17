using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Borwell_Software_Challenge
// Original Task assignement can be found via this link: https://borwell.com/career/ , under 'Software Engineering Jobs'
{

    class Program
    {

        static void Main(string[] args)
        {

            // --> Setting the loop control variable
            bool Finished = false;

            while (Finished == false)
            {

                // --> Setting a new iterative loop up
                bool ResetInput = false;

                while (ResetInput == false)

                {

                    // --> Declaring the title of the program and giving the user the option to Quit
                    Console.WriteLine("Borwell Software Challenge");
                    System.Threading.Thread.Sleep(375);
                    Console.WriteLine();


                    // --> The user now enters their room dimensions in a given order, to a declared accuracy
                    Console.WriteLine("Enter the following values to 2 decimal places");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("- Firstly  please enter 'X-Axis' (length) Value of wall in meters");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("- Secondly please enter 'Y-Axis' (width)  Value of wall in meters");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("- Finally  please enter 'Z-Axis' (height) Value of wall in meters");
                    System.Threading.Thread.Sleep(125);
                    Console.WriteLine();
                    Console.WriteLine();
                

                    // --> Letting the user define each of the values in 'String-form'
                    string sX_Axis_Length = Console.ReadLine();
                    Console.WriteLine();
                    string sY_Axis_Width = Console.ReadLine();
                    Console.WriteLine();
                    string sZ_Axis_Height = Console.ReadLine();
                    Console.WriteLine();





                    // --> Converting the dimensions from String-form' into calculable Double Values
                    //   (Decimal values would also work, however Integer values are too inprecise)
                    // --> In this case, I used 'EnteredValue.TryParse' where I could have instead
                    //   used "try" and "catch" but felt this was a far more clear response.


                    double dX_Axis_Length;
                    bool Successful_X_Axis_Conversion = double.TryParse(sX_Axis_Length, out dX_Axis_Length);
                    if (! Successful_X_Axis_Conversion)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" The value entered was not a valid floating point number. ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(215);
                        Console.WriteLine("    *Please enter a valid X-Axis input!*   ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(215);
                        Console.WriteLine("     RESETTING FOR YOU TO RE-TRY NOW...    ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(1250);
                        System.Console.Clear();
                        ResetInput = true;
                        return;
                    }


                    double dY_Axis_Width;
                    bool Successful_Y_Axis_Conversion = double.TryParse(sY_Axis_Width, out dY_Axis_Width);
                    if (! Successful_Y_Axis_Conversion)
                    {
                        Console.WriteLine(" The value entered was not a valid floating point number. ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(215);
                        Console.WriteLine("    *Please enter a valid Y-Axis input!*   ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(215);
                        Console.WriteLine("     RESETTING FOR YOU TO RE-TRY NOW...    ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(1250);
                        System.Console.Clear();
                        ResetInput = true;
                        return;
                    }


                    double dZ_Axis_Height;
                    bool Successful_Z_Axis_Conversion = double.TryParse(sZ_Axis_Height, out dZ_Axis_Height);
                    if (!Successful_Z_Axis_Conversion)
                    {
                        Console.WriteLine(" The value entered was not a valid floating point number. ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(215);
                        Console.WriteLine("    *Please enter a valid Z-Axis input!*   ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(215);
                        Console.WriteLine("     RESETTING FOR YOU TO RE-TRY NOW...    ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(1250);
                        System.Console.Clear();
                        ResetInput = true;
                        return;
                    }



                    // --> Calculating the Area
                    double dArea_Of_Floor = (dX_Axis_Length * dY_Axis_Width);
                    Console.WriteLine("The area of the floor is " + dArea_Of_Floor + " square metres.");
                    Console.WriteLine();

                    // --> Calculation for the Surface Area (and hence the paint needed)
                    // --> This includes context of an "Area to Paint" ratio and the source
                    double dSurface_Area_Of_Walls = ((2 * (dX_Axis_Length * dZ_Axis_Height)) + (2 * (dY_Axis_Width * dZ_Axis_Height)));
                    double dAmount_Of_Paint_Required = (dSurface_Area_Of_Walls / 10);
                    Console.WriteLine("Given that the average surface area coverage for paint is 10 metres squared per");
                    Console.WriteLine(" litre (according to Homebase), the supposed amount of paint required to cover");
                    Console.WriteLine(" this space ( " + dSurface_Area_Of_Walls + " metres squared) is about " + dAmount_Of_Paint_Required + " litres");
                    Console.WriteLine();

                    // --> Calculating the Volume
                    double dVolume_Of_Room = (dX_Axis_Length * dY_Axis_Width * dZ_Axis_Height);
                    Console.WriteLine("The area of the floor is " + dVolume_Of_Room + " metres cubed.");
                    Console.WriteLine();


                    // --> Letting the user finish and quit the program
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine();
                    Console.WriteLine("Press any key to finish");
                    Console.ReadKey();
                    Finished = true;
                    return;
                    

                }
                // --> Break point if an invalid input was entered previously
                Console.ReadKey();
                Finished = false;

            }

        }

    }

}