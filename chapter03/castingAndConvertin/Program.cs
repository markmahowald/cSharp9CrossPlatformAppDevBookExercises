using System;
using static System.Console;
using static System.Convert;

namespace castingAndConvertin
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            WriteLine(b);

            double c = 9.8;
            int d = (int)c;
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = long.MaxValue;
            f = (int) e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int) e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            WriteLine("rounding demo");
            double [] doubles = new double[] 
            { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

            foreach (var n in doubles)
            {
              WriteLine($"ToInt({n}) is {ToInt32(n)}");  
            }
            foreach (double o in doubles)
            {
                WriteLine("Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                arg0: o, 
                arg1: Math.Round(value: o, digits: 0, 
                mode: MidpointRounding.AwayFromZero));
            }

            WriteLine();
            WriteLine("Converting using ToString");
            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            WriteLine();
            WriteLine("binary to string encoding");
            byte[] binaryObject = new byte[128];
            (new Random()).NextBytes(binaryObject);
            WriteLine("binary object as bytes");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X}");
            }
            WriteLine();
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($" Binary Object encoded as Base 64 {encoded}");

            WriteLine();
            WriteLine("parsing strings demo");
            
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 july 1980");
            WriteLine($"I was born {age} years ago");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"again, my birthday is {birthday:D}");
            
            //int count = int.Parse("abc");
            WriteLine("how many eggs are there");
            int count;
            string input = ReadLine();
            if (int.TryParse(input, out count))
            {
                WriteLine($"thereare {count} eggs.");

            }
            else
            {
                WriteLine("I could not parse the input");
            }

        }

    }
}
