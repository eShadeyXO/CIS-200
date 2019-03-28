//GRADING ID: D1220
//PROGRAM 0
//DUE: Monday, September 11,2017
//CIS 200-76
//Console application to text the address, parcel, and letter classes. Will display letter information and cost.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new address objects.
            Address address1 = new Address("Betty", "101 Wildwood Drive", "Louisville", "KY", 40220);
            Address address2 = new Address("Jim", "1800 wejtnkerjetnkjerntkerntk", "lekrntjnertjnet Lane", "Louisville", "KY", 40245);
            Address address3 = new Address("Lafonda", "132 S 2nd Street", "Louisville", "KY", 40299);
            Address address4 = new Address("Timmy", "17552456 Spring Street", "Louisville", "KY", 40248);

            //Create new letter objects
            Letter letter1 = new Letter(address1, address2, 100.00m);
            Letter letter2 = new Letter(address2, address1, 50.00m);
            Letter letter3 = new Letter(address3, address4, 75.00m);

            //Construct a list sof Parcels.
            List<Parcel> ParcelList = new List<Parcel>
            {
                letter1,
                letter2,
                letter3
            };

            //Loop to step through the list
            foreach (Parcel letter in ParcelList)
            {
                Console.WriteLine(letter);
            }

        }
    }
}
