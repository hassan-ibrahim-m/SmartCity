using System;
using System.Collections.Generic;
namespace smartcity
{
    class APIs
    {
        public static int initiateTrip(string mapID, int carID, string start)
        {
            int ID=0; // will be auto generated in the database and retieved to the return
            // add the trip to the database
            return ID;
        }

        public static List<Node> getRoute(string mapID, string start, string destination, int tripID)
        {
            List<Node> route = Agent.getRoute(mapID, start, destination, tripID);
            return route;
        }
        public static void sendReport(int tripID, Tuple<string, string, double, double, double, double> edgeData, Boolean isEnded)
        {
            int ID=0; // will be auto generated in the database and retrieved
            Report report = new Report(ID, tripID, edgeData, isEnded);
            Agent.updateValue(report);
            
        }
    }
}
