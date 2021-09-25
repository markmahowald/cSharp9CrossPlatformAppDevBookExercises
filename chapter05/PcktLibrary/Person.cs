using System;
using System.Collections.Generic;
using static System.Console;

namespace Pckt.Shared
{
    public partial class Person : object, IComparable<Person>
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        public const string Species = "Homo Sapien";

        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instaniated;
        
        public Person()
        {
            Name = "Unknown";
            Instaniated = DateTime.Now;
        }
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            this.HomePlanet = homePlanet;
            Instaniated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}");

        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string Name, int Number) GetFruit()
        {
            return("Apples", 5);
        }

        public string SayHello()
        {
            return $"{this.Name} says 'Hello!'";
        }
        public string SayHello(string name)
        {
            return $"{this.Name} says 'Hello {name}";
        }

        public string OptionalPeramater(string command = "RUN!", double number = 0.0, bool active = true)
        {
            return string.Format(
                format: "command is {0}, number is {1}, and active is {2}"
                , arg0: command
                , arg1: number
                , arg2: active
            );
        }

        public void PassingParameters(int x, ref int y,  out int z)
        {
            z = 99;
            x++;
            y++;
            z++;
        }


        //chapter 6

        //static method to multiply:
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        //instance method to multiply
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        public static Person operator * (Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        public static int Factorial(int number)
        {
            if(number<0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than 0. ");

            }
            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                WriteLine($"entering local factorial with {localNumber}");
                if (localNumber<1) return 1;
                var result =  localNumber*localFactorial(localNumber-1);
                WriteLine($"result of local factorial is {result}");
                return result;
            }

        }
        //events and deligates.
        public event EventHandler Shout;
        public int AngerLevel;
        public void Poke( )
        {
            AngerLevel++;
            if (AngerLevel>=3)
            {
                if(Shout!=null)
                {
                    Shout?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}