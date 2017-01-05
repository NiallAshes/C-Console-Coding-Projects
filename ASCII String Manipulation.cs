using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASCII_String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a program that can be used to find the ASCII value of a specific letter from a word
            Console.WriteLine("String to ASCII Converter");
            Console.WriteLine();

            // Here the user enters the word they wish to work from
            Console.WriteLine("Enter a word now: ");
            string strInput = Console.ReadLine();
            string StringToBeSearched = strInput.Trim();

            // Here the user decides upon the letter that they want to know the value for
            Console.WriteLine("Position in previous String (e.g. for 1st letter, enter '1'): ");
            strInput = Console.ReadLine();
            int StringPosition = Convert.ToInt32(strInput) - 1;

            // During this process below, the program looks for the character's ASCII
            //  value by locating that position and searching a sort of 'index' for
            //  the value, which can then be returned and output to the user
            string CharacterFound = StringToBeSearched.Substring(StringPosition, 1);
            byte[] ASCII_Value = Encoding.ASCII.GetBytes(StringToBeSearched);

            // Here, the user has the value they were looking for declared to them,
            //  before they are told to close the program by pressing enter
            Console.WriteLine("That is '" + CharacterFound + "' which has an ASCII value of " + ASCII_Value[StringPosition]);
            Console.WriteLine("Press Enter to quit the program");
            Console.ReadKey();
            
        }
    }
}
