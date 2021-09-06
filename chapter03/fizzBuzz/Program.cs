using System;
using static System.Console;
using System.Diagnostics;
using System.Text;


namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("The much praised fizzbuzz is here!");
            Stopwatch timer = new Stopwatch();

            #region solution1
            timer.Start();
            for (int i = 1; i <= 100000; i++)
            {
                string output = "";
                if (i%3==0)
                {
                    output += "Fizz ";
                
                }
                if (i%5 ==0)
                {
                    output+="Buzz";
                }
                WriteLine($"For {i} -> {output}");
            }
            WriteLine();
            timer.Stop();
            string timer1 = timer.Elapsed.ToString();
            #endregion

            #region  solution2
            timer.Start();
            for (int i = 1; i <= 100000; i++)
            {
                string output = "";
                switch ((++i%3 ==0, ++i%5 ==0))
                {
                    case (true,true):
                    output = "Fizz Buzz";
                    break;

                    case (true, false):
                    output = "Fizz";
                    break;

                    case (false, true):
                    output = "Buzz";
                    break;

                    case (false, false):
                    break;
                }

                
                WriteLine($"For {i} -> {output}");
            }
            WriteLine();
            timer.Stop();
            string timer2 = timer.Elapsed.ToString();


            #endregion

            #region  solution 3
            timer.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 100000; i++)
            {
                sb.Clear();
                if (i%3==0)
                {
                    sb.Append("Fizz ");
                
                }
                if (i%5 ==0)
                {
                    sb.Append("Buzz");
                }
                WriteLine($"For {i} -> {sb}");
            }
            WriteLine();
            timer.Stop();
            string timer3 = timer.Elapsed.ToString();
            #endregion


            WriteLine($"Version 1 of fizzbuzz took {timer1}");
            WriteLine($"Version 2 of fizzbuzz took {timer2}");
            WriteLine($"Version 3 of fizzbuzz took {timer3}");
        }
    }
}
