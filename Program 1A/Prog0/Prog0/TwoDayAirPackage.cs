// Program 1a
// CIS 200-76
// Fall 2017
// Due: 9/25/2017
// D1220
// File: Program.cs
// A class for packages being shipped two day air
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver}; //Defines 2 choice enumeration for delivery

        private Delivery _deliveryType; //Backing field to hold delivery type

        //Precondition: None
        //Postcondition: Creates a two day air package with the specified paramter values.
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight, Delivery deliveryType) : base(originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = deliveryType;
        }

        public Delivery DeliveryType
        {
            //Precondition: None
            //Postcondition: Returns delivery type
            get { return _deliveryType; }
            //Precondition: None
            //Postcondition: Sets delivery type to value
            set { _deliveryType = value; }
        }

        //Precondition: None
        //Postcondition: The calculated cost for the package is returned.
        public override decimal CalcCost()
        {
            decimal baseCost = .25m * ((decimal)Length + (decimal)Width + (decimal)Height) + .25m * ((decimal)Weight);
            if (DeliveryType == Delivery.Saver)
                return baseCost * .9m;
            else
                return baseCost;
        }

        //Precondition: None
        //Postcondition: Returns a string representation of the package.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{NL}{base.ToString()}";
        }
    }
}
