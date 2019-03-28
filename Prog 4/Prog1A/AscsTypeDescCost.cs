//Program 1A
//CIS 200-76
//Fall 2017
//Due: 9/25/2017
//GRADING ID: D1220
//File: AscsTypeDescCost.cs
//This class sorts the list of parcels first by type (ascending) and then by cost (descending)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class AscsTypeDescCost : IComparer<Parcel>
    {
        //Precondition: None
        //Postcondition: When item1 < item2 return a negative number. When item1 == item2 return zero. When item1 > item2 return 
        //a positive number.
        public int Compare(Parcel item1, Parcel item2)
        {
            string type1; //Stores item1 type
            string type2; //Stores item2 type

            if (item1 == null && item2 == null)
                return 0;

            if (item1 == null)
                return -1;

            if (item2 == null)
                return 1;

            type1 = item1.GetType().ToString();
            type2 = item2.GetType().ToString();

            if (type1 == type2)
                return (item1.CalcCost()).CompareTo(item2.CalcCost());

            return type1.CompareTo(type2);
        }
    }
}
