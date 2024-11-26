/*
Lab 6
CIS-199-50
Grading ID : A1006
Due 10/29/2023

This is a Program that displays different star patterns.
 */



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set min and max row limit, min is to count down from 10.
            const int maxRow = 10;
            const int minRow = 1;

            Console.WriteLine("Pattern A");
            Console.WriteLine();

            //start row from 1 and increase by 1 until the maxRow(10) limit.
            //Draw star until the row value, increasing it's number to match up.
            for (int row = 1; row <= maxRow; row++)
            {
                for (int star = 0; star < row; ++star)
                {  
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pattern B");
            Console.WriteLine();

            //start row from 10 and decrease by 1 until the minRow(1) limit.
            //Draw star until the row value, increasing it's number to match up.
            for (int row = 10; row >= minRow; row--)
            {
                for (int star = 0; star < row; ++star)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pattern C");
            Console.WriteLine();

            //start row from 10 and decrease by 1 until the minRow(1) limit.
            //Set reverseRow number so that it would go from 0 to 9.
            //Draw spaces based on reverseRow count, followed by stars drawn based on row count.

            for (int row = 10; row >= minRow; row--)
            {
                int reverseRow = (10 - row);
                for (int space = 0; space < reverseRow; ++space)
                {
                    Console.Write(" ");                
                }                                  
                for (int star = 0; star < row; ++star)
                {;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pattern D");
            Console.WriteLine();

            //start row from 1 and increase by 1 until the maxRow(10) limit.
            //Set reverseRow number so that it would go from 9 to 0.
            //Draw spaces based on reverseRow count, followed by stars drawn based on row count.
            for (int row = 1; row <= maxRow; row++)
            {
                int reverseRow = (10 - row);
                for (int space = 0; space < reverseRow; ++space)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < row; ++star)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}