using System;
using System.Collections.Generic;
namespace smartcity
{
    class Trip
    {
       private int ID;
       private int carID;
       private string mapID;
       private string start;
       private string destination;
       private List<Node> route;
       private double time;
       private Tuple<string, string ,string , double> actionValues;
       // Tuple<"action_1_start|action_1_end", "action_2_start|action_2_end", "action_3_start|action_3_end", value>

       public Trip(int ID, string mapID, int carID, string start, string end)
       {
           this.ID=ID;
           this.mapID=mapID;
           this.carID=carID;
           this.start=start;
           this.destination=end;
       }
       public string getMapID(){return this.mapID;}
       public int getTripID(){return this.ID;}
       public string getStart(){return this.start;}
       public string getDestination(){return this.destination;}
       
    }
}
