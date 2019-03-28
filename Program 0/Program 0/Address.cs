//GRADING ID: D1220
//PROGRAM 0
//DUE: Monday, September 11,2017
//CIS 200-76
//An address class to define an address and what things it has (city, state, zip, etc.)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    class Address
    {
        private string _name; //Backing field to hold name
        private string _address1; //Backing field to hold address line 1
        private string _address2; //Backing field to hold address line 2
        private string _city; //Backing field to hold city
        private string _state; //Backing field to hold state
        private int _zip; //Backing field to hold zip code

        //Constructor
        //Precondition: Address must have a name, address line 1, address line 2, city, state, and zip code between 0-99999.
        //Postcondition: A package has been constructed with the specified properties.
        public Address(string name, string address1, string address2, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }

        //Overloaded constructor
        //Precondition: Address must have name, address line 1, city, state, and zip code between 0-99999.
        //Postcondition: A package has been constructed witht he specified properties.
        public Address(string name, string address1, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            City = city;
            State = state;
            Zip = zip;
        }

        
        public string Name
        {
            //Precondition: None
            //Postcondition: Name is returned
            get { return _name; }
            //Precondition: Name cannot be null or whitespace.
            //Postcondition: Name backing field is set to value.
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Name can't be blank.");
                }
                else
                {
                    _name = value;
                }
            }
        }


        public string Address1
        {
            //Precondition: None
            //Postcondition: Address 1 is returned
            get { return _address1; }
            //Precondition: Address1 cannot be null or whitespace.
            //Postcondition: Address1 backing field is set to value.
            set
            {
            if (string.IsNullOrWhiteSpace(value))
            {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Address can't be blank.");
                }
            else
            {
                _address1 = value;
            }
        }
        }


        public string Address2
        {
            //Precondition: None
            //Postcondition: address 2 is returned
            get { return _address2; }
            //Precondition: None
            //Postcondition: Address2 backing field is set to value.
            set { _address2 = value; }
        }


        public string City
        {
            //Precondition: None
            //Postcondition: City is returned
            get { return _city; }
            //Precondition: City cannot be null or whitespace.
            //Postcondition: City backing field is set to value.
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "City can't be blank.");
                }
                else
                {
                    _city = value;
                }
            }
        }


        public string State
        {
            //Precondition: None
            //Postcondition: State is returned
            get { return _state; }
            //Precondition: State cannot be null or whitespace.
            //Postcondition: State backing field is set to value.
            set
            { if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "State can't be blank.");
                }
                else
                {
                    _state = value;
                }
            }
        }
        public int Zip
        {
            //Precondition: None
            //Postcondition: Zip code is returned
            get { return _zip; }
            //Precondition: Zip must be between 0-99999.
            //Postcondition: Zip backing field is set to value.
            set
            {
                if (value > 0 && value < 99999)
                {
                    _zip = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Zip code must be 0-99999.");
                }
            }
        }


        //Precondition: None
        //Postcondition: Returns a string representation of address class.
        public override string ToString() =>
            "Name: " + Name + System.Environment.NewLine +
            "Address: " + Address1 + System.Environment.NewLine +
            Address2 + (string.IsNullOrWhiteSpace(Address2) ? "" : System.Environment.NewLine) +
            City + ", " + State + " " + Zip.ToString("d5");

    }
}
