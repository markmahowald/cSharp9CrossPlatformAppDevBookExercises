using System;
using static System.Console;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a++;
            WriteLine($"a is {a}, and b is {b}");

            int c = 3;
            int d = ++c;
            WriteLine();
            WriteLine($"c is {c}, and d is {d}");

            int e = 11;
            int f = 3;
            WriteLine();
            WriteLine($"e is {e}, and f is {f}");
            WriteLine($"e+f is {e+f}");
            WriteLine($"e-f is {e-f}");
            WriteLine($"e*f is {e*f}");
            WriteLine($"e/f is {e/f}");
            WriteLine($"e%f is {e%f}");

            WriteLine();

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g/f is {g/f}");
            int h;

        }
    }
}
