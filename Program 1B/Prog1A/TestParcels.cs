//GRADING ID: D1220
//ASSIGNMENT: Program 1B
//CLASS: CIS 200-76
//DUE: October 4, 2017

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Namey McNamerson", "666 McAddresson Way", 
                "Palo Alto", "CA", 94020); //Test Address 5
            Address a6 = new Address("John Lennon", "123 E Main St.", 
                "New York", "NY", 10037); //Test Address 6
            Address a7 = new Address("Rosetta Williams", "1793 Jefferson St.", 
                "Eastville", "VA", 23347); //Test Address 7
            Address a8 = new Address("Ryan Colby", "4704 Happy Hollow Road",
                "Wallace", "NC", 28466); //Test Address 8


            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test objects
            Letter letter2 = new Letter(a7, a8, 5.00M);
            Letter letter3 = new Letter(a5, a6, 2.50M);

            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test objects
            GroundPackage gp2 = new GroundPackage(a5, a8, 10, 20, 30, 76);
            GroundPackage gp3 = new GroundPackage(a6, a7, 5, 30, 100, 40);

            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test objects
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a1, a8, 30, 30, 30,
                50, 10.00M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a7, 10, 15, 20,
                30, 5.00M);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test objects
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a4, a5, 32, 65, 12,
                100, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a5, a6, 5, 5, 5,
                3, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            //Select all Parcels and order by destination zip (descending)
            var orderByDestZip =
                from parcel in parcels
                orderby parcel.DestinationAddress.Zip descending
                select parcel;

            // display query results
            Console.WriteLine("Results of query orderByDestZip"); //First task output label
            Console.WriteLine("================================"); //Line
            foreach(var parcel in orderByDestZip)
            {
                Console.WriteLine(parcel);
                Console.WriteLine("====================");
            }

            //Select all Parcels and order by cost (ascending)
            var orderByCost =
                from parcel in parcels
                orderby parcel.CalcCost() ascending
                select parcel;

            //display query results
            Console.WriteLine("Results of query orderByCost");
            Console.WriteLine("================================");
            foreach (var parcel in orderByCost)
            {
                Console.WriteLine(parcel);
                Console.WriteLine("====================");
            }

            //Select all Parcels and order by Parcel type (ascending) and then cost (descending)
            var orderByTypeAndCost = 
                from parcel in parcels
                orderby parcel.GetType() ascending
                orderby parcel.CalcCost() descending
                select parcel;

            //Display query results
            Console.WriteLine("Results of query orderByTypeAndCost");
            Console.WriteLine("================================");
            foreach (var parcel in parcels)
            {
                Console.WriteLine(parcel);
                Console.WriteLine("====================");
            }

            //Select all AirPackage objects that are heavy and order by weight (descending)
            var selectHeavyAirPackages =
                from parcel in parcels
                let ap = parcel as AirPackage
                where (ap != null) && ap.IsHeavy()
                orderby ap.Weight ascending
                select parcel;

            //Display query results
            Console.WriteLine("Results of query orderByTypeAndCost");
            Console.WriteLine("================================");
            foreach (var parcel in parcels)
            {
                Console.WriteLine(parcel);
                Console.WriteLine("====================");
            }

            //Display entire list of parcels
            Console.WriteLine("================================");
            Console.WriteLine("Original List:");
            Console.WriteLine("================================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();
       }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
