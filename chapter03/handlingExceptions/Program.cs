using System;
using static System.Console;


namespace handlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("before parsing");
            Write("what is your age? ");
            string input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old");
            }
            catch(FormatException)
            {
                WriteLine("the age you entered was not in a valid number format");
            }
            catch(OverflowException)
            {
                WriteLine("Your age is a valid number but is either too small or too large");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("after parsing");
        }
    }
}
