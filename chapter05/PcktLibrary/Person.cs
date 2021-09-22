using System;
using System.Collections.Generic;
using static System.Console;

namespace Pckt.Shared
{
    public partial class Person : object
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
    }
}