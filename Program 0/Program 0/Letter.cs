//GRADING ID: D1220
//PROGRAM 0
//DUE: Monday, September 11,2017
//CIS 200-76
//A letter class to define a type of parcel.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    class Letter : Parcel
    {
        decimal _fixedCost; //Backing field for fixed cost

        //constructor
        //Precondition: Must have an origin address, dest address, and fixed cost
        //Postcondition: Constructs a letter.
        public Letter(Address originAddress, Address destAddress, decimal fixedCost) : base(originAddress, destAddress)
        {
            FixedCost = fixedCost;
        }


        private decimal FixedCost
        {
            //Precondition: None
            //Postcondition: Returns fixed cost.
            get { return _fixedCost; }
            //Precondition: None
            //Postcondition: Sets value to fixed cost.
            set { _fixedCost = value; }
        }

        //Precondition: None
        //Postcondition: Returns fixed cost.
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        //Precondition: None
        //Postcondition: Returns a string representation of letter.
        public override string ToString() =>
            "Origin Address: " + System.Environment.NewLine +
            OriginAddress + System.Environment.NewLine + System.Environment.NewLine +
            "Destination Address: " + System.Environment.NewLine +
            DestinationAddress + System.Environment.NewLine + System.Environment.NewLine +
            "Cost of shipping: " + CalcCost().ToString() + System.Environment.NewLine;
    }
}
