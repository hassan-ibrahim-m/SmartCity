


/*
To-Do List:
- Define some cars
- Call RandomTripCreator
- Create an infinite loop to continuoe 
*/


using System;
using System.Collections.Generic;
namespace smartcity
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Database.cars.Add(new Car(0));
            Database.cars.Add(new Car(1));
            Database.cars.Add(new Car(2));
            Database.cars.Add(new Car(3));

            RandomTripCreator.generate(); //create some trips and assign it to the cars

            bool traffic_on = false;
            for(int i=0;i<Database.cars.Count;i++)
            {
               if(Database.cars[i].isOnTrip())
               {
                   traffic_on=true;
                   break;
               }
            }
            while(traffic_on)
            {
                for(int i=0;i<Database.cars.Count;i++)
                {
                    if(Database.cars[i].isOnTrip())
                    {
                        Car car = Database.cars[i];
                        Trip trip = Database.trips[car.getCurrentTrip()];

                        //List<Node> getRoute(string mapID, string start, string destination, int tripID)
                        string mapID = trip.getMapID();
                        int tripID = trip.getTripID();
                        string start = trip.getStart();
                        string destination = trip.getDestination();

                        car.move(Agent.getRoute(mapID, start, destination, tripID));
                    }
                }
            }
        }
    }
}
