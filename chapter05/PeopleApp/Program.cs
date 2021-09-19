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

            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | 
            WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

            bob.Children.Add(new Person{Name = "Alfred"});
            bob.Children.Add(new Person{Name = "Zoe"});

            WriteLine($"{bob.Name} has {bob.Children.Count } children:  ");

            for (var child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($"{bob.Children[child].Name}");
            }

            BankAccount.InterestRate = 0.012M;
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;
            WriteLine(format: "{0} earned {1:C} interest" 
                , arg0 : jonesAccount.AccountName
                , arg1: jonesAccount.Balance * BankAccount.InterestRate
            );

            var gerrierAcount = new BankAccount();
            gerrierAcount.AccountName = "Mrs.Gerrier";
            gerrierAcount.Balance = 98;
            WriteLine(format: "{0} earned {1:C} interest" 
                , arg0 : gerrierAcount.AccountName
                , arg1: gerrierAcount.Balance * BankAccount.InterestRate
            );

            WriteLine($"{bob.Name} is a {Person.Species}");

            WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

            var blankPerson = new Person();

            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}."
            , arg0: blankPerson.Name
            , arg1: blankPerson.HomePlanet
            , arg2: blankPerson.Instaniated);

            var gunny = new Person("gunny", "Mars");

            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}."
            , arg0: blankPerson.Name
            , arg1: blankPerson.HomePlanet
            , arg2: blankPerson.Instaniated);

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());

            var  fruit = bob.GetFruit();
            WriteLine($"{fruit.Name}, {fruit.Number}");

            (string fruitName, int fruitNumber) = bob.GetFruit();

            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");
        }
    }
}
