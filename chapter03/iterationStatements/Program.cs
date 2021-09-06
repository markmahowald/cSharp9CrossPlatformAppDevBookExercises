using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace iterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x<10)
            {
                WriteLine(++x);
                //WriteLine(x++);
                
            }

            string password = string.Empty;
            int wrongAttempts = 1;
            do
            {
                Write("Enter your Password: ");
                password = ReadLine();
            } while (password != "Pa$$w0rd" && ++wrongAttempts<=3);
            if (wrongAttempts>=3)
            {
                WriteLine("Unauthorized access attempt detected. ");
            }
            else
            {
                WriteLine("Correct!");
            }

            for (var i = 0; i <= 10; i++)
            {
                WriteLine(i);
            }

            string[] names = {"Adam", "Barry", "Charlie"};
            foreach (var name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

            WriteLine("iEnumerable test");
            IEnumerator e = names.GetEnumerator();
            while (e.MoveNext())
            {
                string name = (string)e.Current;
                WriteLine($"{name} has {name.Length} characters.");
            }

        }
    }
}
