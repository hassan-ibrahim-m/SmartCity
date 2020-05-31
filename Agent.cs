using System;
using System.Collections.Generic;
namespace smartcity
{
    class Agent
    {
        // Tuple<"action_1_start|action_1_end", "action_2_start|action_2_end", "action_3_start|action_3_end", value>
        private double gamma;
        private double delta;
        public static List<Node> getRoute(string mapID, string start, string destination, int tripID)
        {
            
            SC_Map sc_map = Database.selectMap(mapID); // Select query
            // Note: The data of this map should have also a data about every edge in it 
            //       (including: distance, density, avSpeed, maxSpeed) (and considering future or expected values of these four factors)

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // while applying the dijestra algorithms, every new edge the algorithm visites do:
                // give a total value to the edge according to this criteria:
                    // - the edge have his own values for the four factors (distance, density, avSpeed, maxSpeed) -  (included in the map as Noted above)
                    double distance=0.0, density=0.0, avSpeed=0.0, maxSpeed=0.0, edgeValue; // Get the first four from the map

                    // - according to the edge value a query will be made to get the action value of these four values (this state)
                    // - the value retrieved using a query as:
                    // - SELECT value FROM "Action_Values" WHERE 
                    //                                         (distance >= "distance_1" & distance <= "distance_2") &
                    //                                         (density >= "density_1" & density <= "density_2") &
                    //                                         (avSpeed >= "avSpeed_1" & avSpeed <= "avSpeed_2") &
                    //                                         (maxSpeed >= "maxSpeed_1" & maxSpeed <= "maxSpeed_2");
                    edgeValue = Database.selectActionValue(distance, density, avSpeed, maxSpeed);


                // the total value of the edge = the value from the query (After applying the discount method)
                // repeat this for all the edges, considering the discount value
                    // - the next edge value = the value itself
                    // - the one after = the value * gamma
                    // - the one after = the value * gamma^2
                    // - and so on...
                
                // according to this sequence we can know the value (weight) for any edge the algorithm visites while it's running
                // at the end of applying the dijestra algorithms, now we have the best route
            List<Node> route = new List<Node>(); // with the data from the dijestra result
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            return route;
        }

        public static void updateValue(Report report)
        {
            double tripValue;
            double avTripsSpeed=1.0;
            double oldEdgeValue;
            double newEdgeValue;
// Report(int ID, int tripID, string firstEnd, string secondEnd, double time, double distance, double density, double avSpeed, double maxSpeed, Boolean isEnded)

            // 1- Calculating the value for the edge
            double curEdgeValue = -1* report.getTime();
            
            

            // 2- using a query, get the value of this actions from the database and apply an avarage method to add the new value to it
            oldEdgeValue = Database.selectActionValue(report.getDistance(), report.getDensity(), report.getAvSpeed(), report.getMaxSpeed());
            newEdgeValue = (oldEdgeValue+curEdgeValue)/2.0; // Attention!!! - This is not how it's done (use the av method)

            // 3- If the trip ended calculate the value for the whole trip and assign this value to the edges of the route
            if(report.getIsEnded())
            {
                tripValue = 100 - (report.getAvSpeed()/avTripsSpeed);
                // the value for the trip = 100 - (tripSpeed/avTripSpeed)*100      // speed = the total distance of the trip / the total time taken

                // using a query, get the value of this actions from the database and add the bonus value to it (in some way)
                //ex:
                newEdgeValue+=tripValue;
            }

            // 4- using a query, update the database with the new value
        }
    }
}
