using System;
using static System.Console;

namespace writingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number} times table");
            for (int row = 0; row <= 12; row++)
            {
                Console.WriteLine($"{ros} x {number} = {row*number}}");
                System.Console.WriteLine();
            }
            
            
        }
        statc void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Console.Write($"Enter a number between 0 & 255:");
                isNumber= byte.Try-Parse(
                    ReadLine(), out byte number);
                )
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    Console.WriteLine($"that was not a valid number");
                    
                }
                
            } while (isNumber);
        }
        static void Main(string[] args)
        {
            RunTimesTable();
        }
    }
}
