using System;
using Pckt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person();

            bob.Name = "Bob SMith";
            bob.DateOfBirth = new DateTime(1965, 12,22);
            System.Console.WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth
            );

            var alice = new Person()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            WriteLine("{0} was born on {1:dd MMM yy}"
            , arg0: alice.Name
            , arg1: alice.DateOfBirth);

            bob.FavoriteWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

            WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}"
            , arg0: bob.Name
            , arg1: bob.FavoriteWonder
            , arg2: (int)bob.FavoriteWonder);
        }
    }
}
