// Program 1a
// CIS 200-76
// Fall 2017
// Due: 9/25/2017
// D1220
// File: Program.cs
// A class for packages being sent next day air.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee; //Backing field for express fee.

        //Precondition: None
        //Postcondition: Next day air package is constructed with the specified parameter values.
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight, decimal expressFee) : base(originAddress, destAddress, length, width,
                height, weight)
        {
            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        {
            //Precondition: None
            //Postcondition: Express fee is returned.
            get
            {
                return _expressFee;
            }
            //Precondition: Express fee must be greater than or equal to zero.
            //Postcondition: Express fee is set to value.
            private set
            {
                if (value >= 0)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException("ExpressFee", value, "Express fee can not be a negative number.");
            }

        }

        //Precondition: None
        //Postcondition: The cost of the next day air package is returned.
        public override decimal CalcCost()
        {
            decimal baseCost = .40m * ((decimal)Length + (decimal)Width + (decimal)Height) + .30m * ((decimal)Weight);
            decimal weightCharge = .25m * ((decimal)Weight);
            decimal sizeCharge = .25m * ((decimal)Length + (decimal)Width + (decimal)Height);

            if (IsHeavy())
                return baseCost += weightCharge;
            else if (IsLarge())
                return baseCost += sizeCharge;
            else
                return baseCost;
        }

        //Precondition: None
        //Postcondition: A string representation of the class is returned.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{NL}{base.ToString()}";
        }
    }
}
