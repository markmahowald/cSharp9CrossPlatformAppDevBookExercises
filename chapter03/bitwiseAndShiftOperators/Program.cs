using System;
using static System.Console;

namespace bitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;
            WriteLine($"a = {a}");
            WriteLine($"b= {b}");
            WriteLine($"a & b = {a&b}");
            WriteLine($"a | b = {a|b}");
            WriteLine($"a ^ b = {a^b}");

            //0101 0000 left shift by three bit columns
            WriteLine($"a << 3= {a<<3}");
            //multiply by 8
            WriteLine($"a * 8 = {a*8}");

            //0000-0011 right shift by one bit column
            WriteLine($"b >>1 = {b>>1}");

        }
    }
}
