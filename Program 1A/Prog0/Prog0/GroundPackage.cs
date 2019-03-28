// Program 1a
// CIS 200-76
// Fall 2017
// Due: 9/25/2017
// D1220
// File: Program.cs
// Package sent on ground, calculates cost of shipping based on package dimensions.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class GroundPackage : Package
    {
        //Precondition: None
        //Postcondition: The ground package is made with the specified origin address, destination
        //address, length, width, height, and weight.
        public GroundPackage (Address originAddress, Address destAddress, double length,
            double width, double height, double weight) : base(originAddress, destAddress,
                length, width, height, weight)
        {

        }

        private int ZoneDistance
        {
            //Precondition: None
            //Postcondition: Returns the zone distance.
            get
            {
                int zoneDist; //To hold zone distance.
                zoneDist = Math.Abs((OriginAddress.Zip / 10000) - (DestinationAddress.Zip / 10000));
                return zoneDist;
            }
        }

        //Precondition: None
        //Postcondition: The cost of the ground package is returned.
        public override decimal CalcCost()
        {
            return .20m * ((decimal)Length + (decimal)Width + (decimal)Height) + .05m * (ZoneDistance + 1) *
                ((decimal)Weight);
        }

        //Precondition: None
        //Postcondition: String representation of the ground package is returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Ground Package{NL}{base.ToString()}";
        }
    }
}
