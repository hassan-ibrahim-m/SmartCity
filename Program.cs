
/////////////////////////////////////////////////////////////////////////////
// This class is temporary and will be replaced by letting simulation running
/////////////////////////////////////////////////////////////////////////////

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
            //(will be replaced by making each individual user responsible for his own trip creation)

            bool traffic_on = false;

            //this loop will be replaced by making the car aware if it's currently on a trip or not
            for(int i=0;i<Database.cars.Count;i++)
            {
               if(Database.cars[i].isOnTrip())
               {
                   traffic_on=true;
                   break;
               }
            }

            // How abdelrahim is moving the traffic flow
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

                        // The car while on a trip it will ask for route every new edge

                        // "Agent.getRoute" is an API that ask the Agent for a route and return it
                        List<Node> route = Agent.getRoute(mapID, start, destination, tripID);  
                        
                        // The method "Car.move()" is invoked after the car call the API "Agent.getRoute" 
                        // and the parameter passed to "Car.move" is the return of the API "Agent.getRoute"
                        car.move(route);
                    }
                }
            }
        }
    }
}
