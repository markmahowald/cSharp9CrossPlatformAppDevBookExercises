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

            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("Emily"));

            WriteLine(bob.OptionalPeramater(command:"test"));

            int a = 10;
            int b = 20;
            int c = 30;

            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            var sam = new Person 
            {
                Name = "Sam"
                , DateOfBirth = new DateTime(1972, 1, 27)
            };

            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            sam.FavoriteIceCream = "ChocolateFudge";
            sam.FavoritePrimaryColor = "ReD";
            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}");
            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");

            sam.Children.Add(new Person {Name = "Charlie"});
            sam.Children.Add(new Person {Name = "Ella"});
            WriteLine($"Sam's first child is named {sam.Children[0].Name}");
            WriteLine($"Sam's 2nd child is named {sam.Children[1].Name}");
            WriteLine($"Sam's 1th child is {sam[0].Name}");
            WriteLine($"Sam's 2 child is {sam[1].Name}");


            object[] passengers = 
            {
                new FirstClassPassenger{AirMiles = 1_419}
                , new FirstClassPassenger{AirMiles = 16_562}
                , new BusinessClassPassenger()
                , new CoachClassPassenger {CarryOnKG = 0 }
            };

            foreach (var passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    FirstClassPassenger p when p.AirMiles > 3500 => 1500M
                    , FirstClassPassenger p when p.AirMiles > 1500 => 1750M
                    , FirstClassPassenger => 2000M
                    , BusinessClassPassenger => 1000M
                    , CoachClassPassenger p when p.CarryOnKG <10.0 => 500M
                    , CoachClassPassenger => 650M
                    , _=> 850M
                };
                
                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }

            var jeff = new ImmutablePerson
            {
                FirstName = "Jeff"
                , LastName = "winger"
            };
            //jeff.FirstName = 

            var car = new ImmutableVehicle
            {
                Brand = "Mazda"
                , Color = "black"
            };

            var repaintedCar = car with {Color = "grey"};

            WriteLine("Original color was {0}, new color is {1}"
            , arg0: car.Color
            , arg1: repaintedCar.Color);
        }
    }
}
