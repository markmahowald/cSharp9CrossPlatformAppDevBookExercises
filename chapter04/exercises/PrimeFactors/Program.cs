using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            RunPrimeFactors();
        }

        private static string PrimeFactors(int variable)
        {
            /*Finding the prime factors
            How to?:
            1. have a list of prime numbers between 0 & 1000 and try modding the input into them, and then recursively calling the input. 
            2. check for the mod of all numbers between 2 and half of input. 

            */
            if (variable ==0)
            {
                return "";
            }
            else if(variable ==1)
            {
                return "1";
            }
            string result = "";
            for (var i = 2; i <= (variable); i++)
            {
                if (variable%i ==0)
                {
                    if(variable/i ==1)
                    {
                        result+= $"{i}";
                        return result;
                    }
                    else
                    {
                        result += $"{i} + {PrimeFactors(variable/i)}";
                        return result;
                    }

                    //return result;
                }
            }
            return result;

        }
        private static void RunPrimeFactors()
        {
            Console.WriteLine("The factors of 1 are : " + PrimeFactors(1));
            Console.WriteLine( "The factors of 50 are : " + PrimeFactors(50));
        }
    }
}
