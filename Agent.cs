using System;
using System.Collections.Generic;
namespace smartcity
{
    class Agent
    {
        private static Tuple<string, string ,string , double> actionValues { get; set; }
        // Tuple<"action_1_start|action_1_end", "action_2_start|action_2_end", "action_3_start|action_3_end", value>
        private double gamma;
        private double delta;
        public static List<Node> getRoute(string mapID, string start, string destination, int tripID)
        {
            actionValues = new Tuple<string, string, string, double>("","","",0.0);
            SC_Map sc_map = Database.SC_Maps[mapID];
            // retrieve the map from the DB with the (mapID), and fill the data to (sc_map)
            
            // while applying the dijestra algorithms, every new edge the algorithm visites do:
            // give a total value to the edge according to this criteria:
            // the edge have his own values for the three factors (distance, density, avSpeed)
            // - the (distance) is given from the map in DB, the (density & avSpeed) is given from a query

            // the value retrieved using a query as:
            // SELECT value FROM "Action_Values" WHERE 
            //                                         (distance >= "distance_1" & distance <= "distance_2") &
            //                                         (density >= "density_1" & density <= "density_2") &
            //                                         (avSpeed >= "avSpeed_1" & avSpeed <= "avSpeed_2");
            // 
            //
            // the total value of the edge = the value from the query
            // repeat this for all the edges, considering the discount value
            // - the next edge value = the value itself
            // - the one after = the value * gamma
            // - the one after = the value * gamma^2
            // - and so on...
            //
            // at the end of applying the dijestra algorithms, now we have a route
            List<Node> route = new List<Node>(); // with the data from the dijestra result
            return route;
        }

        public static void updateValue(Report report)
        {
            // Report(int ID, int tripID, List<Tuple< string   ,  string    , double, double      , double , double  >> edgeData, Boolean isEnded)
            //                                 Tuple<"firstEnd", "secondEnd", time  , avarageSpeed, density, distance>

            // 1- Calculating the value for the edge
            Tuple<string, string, double, double, double, double> Edgedata =  report.getEdgeData();
            double edgeValue = -1* Edgedata.Item3;
            
            // 2- If the trip ended calculate the value for the whole trip and assign this value to the edges of the route
            if(report.getIsEnded())
            {
                // the value for the trip = 100 - (tripSpeed/avTripSpeed)*100      // speed = the total distance of the trip / the total time taken
                // using a query, get the value of this actions from the database and apply an avarage method to add this value to it
            }
            // 3- using a query, get the value of this actions from the database and apply an avarage method to add the new value to it
            // 4- using a query, update the database with the new value
        }
    }
}
