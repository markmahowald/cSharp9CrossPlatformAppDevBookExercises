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
            // RunCalculateTax();
            // RunCardinalToOrdinal();
            // RunFactorial();
            Console.WriteLine($"starting");
            
            //RunFibImperative();
            RunFibFunctional();

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

        /// <summary>
        /// Pass a 32- bit integer and it will be converted into its ordinal equivelant. 
        /// </summary>
        /// <param name="number"> is a cardinal value e.g. 1, 2, 3 etc. 
        /// </param>
        /// <returns>Number as an ordinal value e.g. 1st, </returns>
        private static string CardinalToOrdinal(int number)
        {
            //WriteLine("In CardinalToOrdinal");
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
                //WriteLine("Exiting CardinalToOrdinal");
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
        private static int FibImperative(int term)
        { 
            //WriteLine($"Entering FibImperitive with {term}");
            if (term == 1)
            {
                //WriteLine($"exiting FibImperative with 0");
                return 0;

            }
            else if(term ==2)
            {
                //WriteLine($"exiting FibImperative with 1");
                return 1;
            }
            else
            {
                
                int x =  FibImperative(term-1) + FibImperative(term-2);
                //WriteLine($"exiting FibImperative with {x}");
                return x;
            }
        }
        private static void RunFibImperative()
        {
            WriteLine("entering the loop");
            for (int i = 1; i <=30; i++)
            {
                WriteLine("the {0} term of Fibbonacci is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: FibImperative(i));
                //WriteLine($"Exiting loop {i}");
            }
        }
        private static int FibFunctional(int term) =>
        term switch
        {
            1 => 0, 
            2 => 1, 
            _ => FibFunctional(term-1)+FibFunctional(term-2)
        };
        static void RunFibFunctional()
        {
            for (var i = 0; i <=30; i++)
            {
                WriteLine("The {0} term of the fib sequence is {1:N0}",
                arg0: CardinalToOrdinal(i)
                , arg1: FibFunctional(i)
                );
            }
        }
    }
}
