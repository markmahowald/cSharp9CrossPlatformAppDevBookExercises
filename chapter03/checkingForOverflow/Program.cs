using System;
using static System.Console;

namespace checkingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue-1;
            WriteLine($"Initial value: {x}");
            WriteLine($"value after incrementing{++x}");
            WriteLine($"value after incrementing{++x}");
            WriteLine($"value after incrementing{++x}");
            WriteLine($"value after incrementing{++x}");

            try{
                checked
                {
                    int y = int.MaxValue-1;
                WriteLine($"Initial value: {y}");
                WriteLine($"value after incrementing{++y}");
                WriteLine($"value after incrementing{++y}");
                WriteLine($"value after incrementing{++y}");
                WriteLine($"value after incrementing{++y}");
                }
            }
            catch(OverflowException)
            {
                WriteLine("The code overflowed, but i caught it.");
            }
            unchecked
            {

                int z = int.MaxValue+1;
                WriteLine($"Initial value: {z}");
                WriteLine($"After decrementing: {--z}");
                WriteLine($"After decrementing: {--z}");
                WriteLine($"After decrementing: {--z}");
            }

        }
    }
}
