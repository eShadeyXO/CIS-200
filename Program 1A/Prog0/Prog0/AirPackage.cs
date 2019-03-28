// Program 1a
// CIS 200-76
// Fall 2017
// Due: 9/25/2017
// D1220
// File: Program.cs
// Send package via air, tests how heavy the package is.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    abstract class AirPackage : Package
    {
        //Precondition: None
        //Postcondition: Air package is created with specified values for origin address, destination address, length,
        //width, height, and weight
        public AirPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight) : base(originAddress, destAddress,
                length, width, height, weight)
        {

        }
        //Precondition: None
        //Postcondition: Value for IsHeavy is returned.
        public bool IsHeavy()
        {
            if (Weight >= 75)
                return true;
            else
                return false;
        }

        //Precondition: None
        //Postcondition: Value for IsLarge is returned.
        public bool IsLarge()
        {
            if ((Length + Width + Height) >= 100)
                return true;
            else
                return false;
        }

        //Precondition: None
        //Postcondition: A string representation of the class is returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Air Package{NL}{base.ToString()}";
        }
    }
}
