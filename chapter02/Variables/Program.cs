using System;
using System.IO;
using System.Xml;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a double in an object
            object name = "Amir"; //storing a string as an object
            System.Console.WriteLine($"{name} is {height} meters tall. ");
            
            //int length1 = name.Length; // gives compile error because name is not a string. 
            int length2 = ((string) name).Length; 
            System.Console.WriteLine($"{name} has {length2} characters");

            //storing in a dynamic object
            dynamic anotherName = "Ahmed";
            int length = anotherName.Length;
            System.Console.WriteLine(length); 

            var population = 66_000_000 ;//uk population
            var weight = 1.88 ; // in kg
            var price = 4.99M; // in pounds
            var fruit = "Apples";
            var letter = 'Z';
            var happy = true;

            // // good use of var
            // var xml1 = new XmlDocument();
            // XmlDocument xml2 = new XmlDocument();
            // // bad use of var
            // var file1 = File.CreateText(@"C:\something.txt");
            // StreamWriter file2 = File.CreateText(@"c:\something.txt");

            XmlDocument xml3 = new();

            System.Console.WriteLine($"default for int is {default(int)}");
            System.Console.WriteLine($"default for bool is {default(bool)}");
            System.Console.WriteLine($"default for DateTime is {default(DateTime)}");
            System.Console.WriteLine($"default for string is {default(string)}");

        }
    }
}
