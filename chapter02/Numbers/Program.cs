using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //unsigned integer means positive whole number
            //including 0: 
            uint natrualNumber = 23;
            //integer means negative or positive whole number including zero
            int integerNumber = -23;
            //float means single point precision floating point number
            // the F suffix makes it a float literal
            float realNumber = 2.3F;
            //double means double point precision floating point number. 
            //double needs no suffix. 
            double anotherRealNumber = 2.3;

            //three variables that all store the number 2 million: 
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            //check that all three cariables ahve the same value
            System.Console.WriteLine($"{decimalNotation == binaryNotation}");
            System.Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
            
            System.Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range of {int.MinValue:N0} to {int.MaxValue:N0}.");
            System.Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range of {double.MinValue:N0} to {double.MaxValue:N0}.");
            System.Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range of {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            System.Console.WriteLine("");
            System.Console.WriteLine("Using Doubles:");
            double a = 0.1;
            double b = 0.2;
            if(a +b == 0.3)
            {
                System.Console.WriteLine($"{a} + {b} equals 0.3 right?");
            }
            else
            {
                System.Console.WriteLine($"{a} +{b} does NOT EQUAL 0.3");
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Using Decimals:");
            decimal ad = 0.1M;
            decimal bd = 0.2M;
            if(ad +bd == 0.3M)
            {
                System.Console.WriteLine($"{ad} + {bd} equals 0.3 right?");
            }
            else
            {
                System.Console.WriteLine($"{ad} +{bd} does NOT EQUAL 0.3");
            }
        }
    }
}
