
////////////////////////////////////////////////////////////////////////////////////////////
// This class is temporary and will be replaced by letting the users creates thier own trips
////////////////////////////////////////////////////////////////////////////////////////////


/*
To-Do List:
- Create some trip with dummy data
- Create a method for returning those trips
*/


using System;
using System.Collections.Generic;
namespace smartcity
{
    class RandomTripCreator
    {
        private static List<Trip> trips;
        public static void generate()
        {
            //public Trip(int ID, string mapID, int carID, string start, string end)

            // The ID will be auto generated in the DadaBase and returned to be assigned to the Car

            Database.trips.Add(new Trip(0,"01",0,"A","X"));
            Database.cars[0].setTripID(0);

            Database.trips.Add(new Trip(1,"01",1,"B","F"));
            Database.cars[1].setTripID(1);

            Database.trips.Add(new Trip(2,"01",2,"C","T"));
            Database.cars[2].setTripID(2);

            Database.trips.Add(new Trip(3,"01",3,"D","S"));
            Database.cars[3].setTripID(3);
        }
    }
}



