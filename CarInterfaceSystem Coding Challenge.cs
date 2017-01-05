using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// --> Making a program that follows this program's criteria
namespace CarInterfaceSystem_Coding_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ________________________________________________________________________
            // |                                                                        |
            // |  NOTE:                                                                 |
            // |     Within the annotations for the code below, I refer to "random"     |
            // |     numerical values being generated.  Due to the nature of MS Visual  |
            // |     Studio, however, the way in which these numbers are generated      |
            // |     means that the values are actually only 'pseudo-random'...         |
            // |________________________________________________________________________|



            // --> Defining all four Variables at the start of the program code
            int Internal_Temp = 0;
            int External_Temp = 0;
            bool High_Light_Intensity = false;
            bool High_Electricity_Usage = false;




            // Generating the EXTERNAL TEMPERATURE value

            Random Random1 = new Random();
            // --> Generate a random number between 0 and 32
            int RandomInteger1 = Random1.Next(0, 33);
            // --> Subtract 4 from that generated number, and define it as "External_Temp"
            // --> Hence, the new range is (-4 to 29) degrees Celcius
            External_Temp = ((RandomInteger1) - 4);




            // Generating if LIGHT INTENSITY is High

            Random Random2 = new Random();
            // --> Generate a random whole number less than, or equal to, 1
            // --> Then use the value TrueOrFalse to decide about High_Light_Intensity
            int TrueOrFalse = (Random2.Next(0, 2));
            if (TrueOrFalse == 1)
            {
                High_Light_Intensity = true;
                Console.WriteLine("It is light outside, therefore no in-car lights needed");
                Console.WriteLine();
            }

            else if (TrueOrFalse == 0)
            {
                High_Light_Intensity = false;
                Console.WriteLine();
                Console.WriteLine("It is dark outside, therefore the car's inside lights must stay on");
            }

            // --> Check for program error (JIC - Just In Case)
            else
            {
                Console.WriteLine("Error found, please restart and fix program");
                Console.WriteLine();
                Console.ReadKey();
            }




            // Generating the INTERNAL TEMPERATURE value

            Random Random3 = new Random();
            // --> Generate a random number between 4 and 30
            int RandomInteger2 = Random3.Next(4, 30);
            // --> Subtract  from that generated number, and define it as "Internal_Temp"
            // --> Hence, the new range is (-1 to 25) degrees Celcius
            Internal_Temp = ((RandomInteger2) - 5);




            // --> Declaring the temperature variables
            Console.WriteLine(External_Temp + " degrees Celcius is the external temperature");
            Console.WriteLine(Internal_Temp + " degrees Celcius is the internal temperature");
            Console.WriteLine();


            // --> Addressing to the user whether A/C is needed in the car
            if ( (Internal_Temp <= (External_Temp + 6)) && (Internal_Temp >= (External_Temp - 6)) )
            {
                Console.WriteLine("Temperatures are within a close enough range for Air Conditioning not to be needed");
                Console.WriteLine();
            }

            // --> Check whether parameters listed below are met, & therefore if Electricity will need to be used
            if ( (High_Light_Intensity = true)  ||  ( (Internal_Temp <= (External_Temp + 6)) && (Internal_Temp >= (External_Temp - 6)) ) )
            {
                High_Electricity_Usage = true;
            }

            // --> Outcome for when power is on (if  [High_ Electricity_Usage = true] )
            if (High_Electricity_Usage)
            {
                Console.WriteLine("Power is in use so the engine must remain on");
                Console.WriteLine();
            }

            // --> Outcome for when power is off (if  [High_Electricity_Usage != true] and is therefore false)
            else if (!High_Electricity_Usage)
            {
                Console.WriteLine("Power is not being used so the engine can now fully turn off");
                Console.WriteLine();
            }



            // --> Code to finish the Program
            Console.WriteLine();
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }
}
