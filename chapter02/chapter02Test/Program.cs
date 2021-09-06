using System;
using System.Collections.Generic;
using static System.Console;

namespace chapter02Test
{
    class Program
    {
        static void Main(string[] args)
        {
/* 2.1
Data types for each:

*A person's telephone number - an int formatted for telephone, or maybe a string
*A person's height  - depending on the unit system, a float or a satring. 
*A person's age  - an int unless its a kid who says things like 4 and a half. then float
*A person's salary - int - salarys usually are whole dollars
*A book's ISBN  - an int
*A book's price  - a decimal or float formatted for currency (C)
*A book's shipping weight  - decimal or float
*A country's population  - int
*The number of stars in the universe  - bigint or blob
*The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)  -this sounds like a 2d array [business][population]
*/

/* console app that tells you the number of bytes of each type, and their min and max. 
sbyte , byte , short , ushort , int , uint , long , ulong , float , double , and decimal . 
*/
        List<Type> types = new List<Type>{typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), 
        typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(decimal), typeof(decimal)} ;
    //     System.Console.WriteLine("_________________________________");
    //     System.Console.WriteLine("Type | Bytes | Min | Max");
    //     System.Console.WriteLine("");

    //         Console.WriteLine("{0,-7} {1,10}", "Type", "Bytes", "Min", "Max\n");
    //   foreach (Type type in types)
    //   {
    //      Console.WriteLine($"{type.Name, -8} {sizeof(type.Name), -4}, {type.MinValue,30}, {type.MaxValue, 30}");
          
    //   }
            
            WriteLine("--------------------------------------------------------------------------");
            WriteLine("Type    Byte(s) of memory               Min                            Max");
            WriteLine("--------------------------------------------------------------------------");
            WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            WriteLine("--------------------------------------------------------------------------");
        }
    }
}
