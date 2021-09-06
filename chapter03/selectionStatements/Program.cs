using System;
using static System.Console;

namespace selectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 )
            {
                WriteLine("No args given. ");
            }
            else
            {
                WriteLine("some args were given. ");
            }
            #if true
                WriteLine("how do regions even work?");
            #endif

            object o = 3;
            int j = 4;
            if (o is int i)
            {
                WriteLine($"{i} * {j} = {i*j}");
            }
            else
            {
                WriteLine("o is not an int so cannot multiply!");
            }


            A_label: 
            var number = (new Random()).Next(1,7);
            WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                WriteLine("one");
                    break;

                case 2:
                WriteLine("Two");
                goto case 1;

                case 3:
                case 4:
                WriteLine("three or 4");
                goto case 1;

                case 5: 
                System.Threading.Thread.Sleep(500);
                goto A_label;

                default:
                    WriteLine("Default");
                    break;
            }
            
        }
    }
}
