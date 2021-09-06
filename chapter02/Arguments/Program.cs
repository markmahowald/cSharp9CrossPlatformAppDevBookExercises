using System;
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments");
            foreach (string s in args)
            {
                WriteLine(s);
            }
            if (args.Length < 3)
            {
                WriteLine("You must specify 2 colors and a cursor size, e.g.");
                WriteLine("Dotnet run red yellow 50");

            }else
            {
                ForegroundColor = (ConsoleColor)Enum.Parse(
                    enumType: typeof(ConsoleColor),
                    value: args[0],
                    ignoreCase: true
                );
                BackgroundColor = (ConsoleColor)Enum.Parse(
                    enumType: typeof(ConsoleColor),
                    value: args [1],
                    ignoreCase: true
                );
                try
                {
                    CursorSize = int.Parse(args[2]);
                }
                catch (PlatformNotSupportedException)
                {
                    WriteLine("You are on a mac - you cant change the cursor on this machine. ");
                }
                // if (OperatingSystem.Is)
                // {
                    
                // }
                
            }
        }
    }
}
