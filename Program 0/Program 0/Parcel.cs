//GRADING ID: D1220
//PROGRAM 0
//DUE: Monday, September 11,2017
//CIS 200-76
//A parcel class to define a parcel.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    abstract class Parcel
    {
        private Address _originAddress; //Backing field for origin address
        private Address _destAddress; //backing field for destination address

        //Constructor
        //Precondition: Parcel must have an origin and dest zip.
        //Postcondition: Constructs a parcel.
        public Parcel(Address originAddress, Address destAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destAddress;
        }


        public Address OriginAddress
        {
            //Precondition: None
            //Postcondition: Returns origin address.
            get { return _originAddress; ; }
            //Precondition: None
            //Postcondition: sets value to origin address.
            set { _originAddress = value; }
        }


        public Address DestinationAddress
        {
            //Precondition: None
            //Postcondition: Returns destination address.
            get { return _destAddress; }
            //Preconditon: None
            //Postcondition: Sets value to destination address.
            set { _destAddress = value; }
        }


        public abstract decimal CalcCost();

        //Precondition: None
        //Postcondition: Returns a string representation of Parcel class.
        public override string ToString() =>
            "Origin Address: " + OriginAddress + System.Environment.NewLine +
            "Destination Address: " + DestinationAddress + System.Environment.NewLine;
    }
}
