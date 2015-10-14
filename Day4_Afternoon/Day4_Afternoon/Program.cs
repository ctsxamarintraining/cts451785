using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Afternoon
{
    class Program
    {        
        static void Main(string[] args)
        {
            /*
         * Write a program that reads an integer number and calculates and prints its square root. 
         * If the number is invalid or negative, print "Invalid number”. In all cases finally print "Goodbye". 
         * Use try-catch-finally.
         */
            ReadNumberFromConsole.readInteger();

        /*
        * Write a program that enters filename along with its full file path (e.g c:\Example\myexample.txt ),
        * reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
        * Besure to catch all possible exceptions and print user-friendly error messages.
        */
            Console.WriteLine("Enter path to read the file:");
            FileExceptions.readFile(Console.ReadLine());

        }
    }
}
