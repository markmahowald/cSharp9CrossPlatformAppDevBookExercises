using System;
using static System.Console;

namespace writingFunctions
{
    class Program
    {
        private static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number} times table");
            for (int row = 0; row <= 12; row++)
            {
                Console.WriteLine($"{row} x {number} = {row*number}");
                System.Console.WriteLine();
            }
            
            
        }
        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Console.Write($"Enter a number between 0 & 255:");
                isNumber= byte.TryParse
                (
                    ReadLine(), out byte number
                );
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
            //RunTimesTable();
            //RunCalculateTax();
            //RunCardinalToOrdinal();
            RunFactorial();
        }

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH":
                    rate = 0.08M; 
                    break;
                case "DK":
                case "NO":
                rate = 0.025M;
                break;

                case "CA":
                rate = 0.0825M;
                break;


                default:
                    break;
            }
            return rate*amount;
        }

        static void RunCalculateTax()
        {
            Write("Enter an ammount of Money: ");
            string amountInText =  ReadLine();
            Write("Enter a two letter region code: ");
            string regionCode = ReadLine();
            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, regionCode);
                WriteLine($"You must pay {taxToPay} in tax");

            }
            else
            {
                WriteLine("that was an invalid amount. ");
            }
        }
        private static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                return $"{number}th";

                default:
                int lastDigit = number%10;
                string suffix = lastDigit switch 
                {
                    1=> "st"
                    , 2=> "nd"
                    , 3=> "rd"
                    ,_ => "th"
                };
                return $"{number}{suffix}";
   
                
            }
            
        }
        private static void RunCardinalToOrdinal()
        {
            for (var number = 0; number <=40; number++)
            {
                Write($"{CardinalToOrdinal(number)}   ");

            }
            WriteLine();
        }
        
        private static int Factorial(int number)
        {
            if (number <0)
            {
                return 0;
            }
            else if(number ==1)
            {
                return 1;
            }
            else
            {
                checked
                {
                    return number * Factorial(number-1);

                }
                
            }
        }
        private static void RunFactorial()
        {
            for (var i = 0; i < 15; i++)
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
        }
    }
}
