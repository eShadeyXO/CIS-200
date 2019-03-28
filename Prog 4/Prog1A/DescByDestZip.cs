//Program 1A
//CIS 200-76
//Fall 2017
//Due: 9/25/2017
//GRADING ID: D1220
//File: DescByDestZip.cs
//This class sorts the list of parcels in descending order by destination zip.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescByDestZip : IComparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: When item1 < item2, method returns negative #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns positive #
        public int Compare(Parcel item1, Parcel item2)
        {
            if (item1 == null && item2 == null)
                return 0;

            if (item1 == null)
                return -1;

            if (item2 == null)
                return 1;

            return (item2.DestinationAddress.Zip).CompareTo(item1.DestinationAddress.Zip);
        }
    }
}
