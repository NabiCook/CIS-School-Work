/*
Lab 7
CIS-199-50
Grading ID : A1006
Due 11/12/2023

This is a Program that draws stars based on the user input.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int input=0; //to store user input
            bool parse = false; //for input tryparse.

            while (input != -1) //continues the program until -1 is entered
            {
                //take in user input
                Console.Write("Enter the number of Stars (-1 to end): ");
                parse = int.TryParse(Console.ReadLine(), out input);

                //if the input was int and positive, draw stars
                if (parse && input > 0)
                {
                    //calls the method and send the user input
                    ShowSquareOfStars(input);                   
                }

                //if the input was int and was less than 0,
                else
                {
                    //end the loop for -1.
                    if (input == -1)                    
                        break;
                    //show error for any negative number other than -1
                    else
                        Console.WriteLine("Enter Valid Positive number.");
                }
            }
        }

        static void ShowSquareOfStars(int numStars)
        {
            //external loop for the number of rows
            for (int i = 0; i < numStars ; i++) 
            {
                //internal loop for the number of cols
                for (int j = 0; j < numStars ; j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
