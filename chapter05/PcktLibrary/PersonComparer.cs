using System;
using System.Collections;
using System.Collections.Generic;

namespace Pckt.Shared
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result =  x.Name.Length.CompareTo(y.Name.Length);

            if(result ==0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return result;
            }
        }
    }
}