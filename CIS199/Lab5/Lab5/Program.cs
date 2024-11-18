/*
Lab5
CIS-199-50
Grading ID : A1006
Due 10/16/2023

This is a Program that calculates the mean temperature from user inputs.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool parseResult; //result for tryparse.
            double totalTemp = 0, meanTemp = 0, input; //to store temps and user input.
            int loopCount = 0; //used to count loops.
            const int minTemp = -20, maxTemp = 130, exitCode = 999; //set values for each temp range and sentinel value.

            //send message and tryparse the user input, matching with temperatures range so that it will continue only if both are true.
            Console.WriteLine("Enter temperatures from -20 to 130 (999 to stop)");
            Console.Write("Enter temperature: ");
            parseResult = (double.TryParse(Console.ReadLine(), out input))&&(input >= minTemp && input <= maxTemp);

            //while the input is not 999
            while (input != exitCode) 
            { 
                // if tryparse was successful and values were within the range.
                if (parseResult)
                {
                    //adds temperature to the total. increase loop count.
                    totalTemp = totalTemp + input;
                    ++loopCount;
                }

                //in case the input was not valid, send out error message.
                else
                {
                    Console.WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                    
                }
                //proceed to the next number
                Console.Write("Enter temperature: ");
                parseResult = (double.TryParse(Console.ReadLine(), out input)) && (input >= minTemp && input <= maxTemp);
            }
            //calculate the mean temperature.
            meanTemp = totalTemp / loopCount;

            //send out the results.
            Console.WriteLine($"You entered {loopCount} valid temperatures");
            Console.WriteLine($"The mean temperatures is {meanTemp.ToString("F1")} degrees.");
            

        }
    }
}
