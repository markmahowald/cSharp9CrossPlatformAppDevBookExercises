using System;
using System.Collections.Generic;
using static System.Console;

namespace Pckt.Shared
{
    public class Person : object
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
    }
}