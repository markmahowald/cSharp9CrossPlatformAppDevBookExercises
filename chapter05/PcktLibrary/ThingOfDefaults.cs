using System;
using System.Collections.Generic;
namespace Pckt.Shared
{
    public class ThingOfDefaults
    {
        public int Population; 
        public DateTime When;
        public string Name;
        public List<Person> People;
        public ThingOfDefaults()
        {
            // old way
            // Population = default(int);
            // When = default(DateTime);
            // Name = default(string);
            // People = default(List<Person>);

            //new way
            Population = default;
            When = default;
            Name = default;
            People = default;
            
        }
    }
}