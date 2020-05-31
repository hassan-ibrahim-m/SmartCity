
//////////////////////////////////////////////////////////////////////
// This class is temporary and will be replaced by the actual database
//////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
namespace smartcity
{
    class Database
    {
       public static List<Tuple<string, string, string, string, double>> actionValues;
       public static List<Trip> trips;
       public static List<Car> cars = new List<Car>();
       private static IDictionary<string, SC_Map> SC_Maps = new Dictionary<string, SC_Map>();  // IDictionary<mapID, The map>


       // Queries:

       // Select map from "Maps" where mapID = mapID;
       public static SC_Map selectMap(string mapID)
       {
           return SC_Maps[mapID];
       }

       // Select distance, density, avSpeed, maxSpeed from "edge" where edge = edge;
       public static double selectActionValue(double distance, double density, double avSpeed, double maxSpeed)
       {

           double DB_distance1, DB_distance2, DB_density1, DB_density2, DB_avSpeed1, DB_avSpeed2, DB_maxSpeed1, DB_maxSpeed2, DB_edgeValue=0.0;

           for(int i=0;i<actionValues.Count; i++)
           {
               DB_distance1 = Convert.ToDouble(actionValues[i].Item1.Split('|')[0]);
               DB_distance2 = Convert.ToDouble(actionValues[i].Item1.Split('|')[1]);
               DB_density1 = Convert.ToDouble(actionValues[i].Item2.Split('|')[0]);
               DB_density2 = Convert.ToDouble(actionValues[i].Item2.Split('|')[1]);
               DB_avSpeed1 = Convert.ToDouble(actionValues[i].Item3.Split('|')[0]);
               DB_avSpeed2 = Convert.ToDouble(actionValues[i].Item3.Split('|')[1]);
               DB_maxSpeed1 = Convert.ToDouble(actionValues[i].Item4.Split('|')[0]);
               DB_maxSpeed2 = Convert.ToDouble(actionValues[i].Item4.Split('|')[1]);

               if(distance >= DB_distance1 && distance < DB_distance2 &&
                  density >= DB_density1 && distance < DB_density2 &&
                  avSpeed >= DB_avSpeed1 && distance < DB_avSpeed2 &&
                  maxSpeed >= DB_maxSpeed1 && distance < DB_maxSpeed2)
                  {
                      DB_edgeValue = actionValues[i].Item5;
                  }
           }
           return DB_edgeValue; // If there is no value, the value returned will be something like "-1" or "null"
       }

       // update distance, density, avSpeed, maxSpeed, value from "edge" where edge = edge;
       public static void updateActionValue(double distance, double density, double avSpeed, double maxSpeed, double value)
       {

           double DB_distance1, DB_distance2, DB_density1, DB_density2, DB_avSpeed1, DB_avSpeed2, DB_maxSpeed1, DB_maxSpeed2;

           for(int i=0;i<actionValues.Count; i++)
           {
               DB_distance1 = Convert.ToDouble(actionValues[i].Item1.Split('|')[0]);
               DB_distance2 = Convert.ToDouble(actionValues[i].Item1.Split('|')[1]);
               DB_density1 = Convert.ToDouble(actionValues[i].Item2.Split('|')[0]);
               DB_density2 = Convert.ToDouble(actionValues[i].Item2.Split('|')[1]);
               DB_avSpeed1 = Convert.ToDouble(actionValues[i].Item3.Split('|')[0]);
               DB_avSpeed2 = Convert.ToDouble(actionValues[i].Item3.Split('|')[1]);
               DB_maxSpeed1 = Convert.ToDouble(actionValues[i].Item4.Split('|')[0]);
               DB_maxSpeed2 = Convert.ToDouble(actionValues[i].Item4.Split('|')[1]);

               if(distance >= DB_distance1 && distance < DB_distance2 &&
                  density >= DB_density1 && distance < DB_density2 &&
                  avSpeed >= DB_avSpeed1 && distance < DB_avSpeed2 &&
                  maxSpeed >= DB_maxSpeed1 && distance < DB_maxSpeed2)
                  {
                      // assigning the new value to the Tuple of actions
                      actionValues[i] = new Tuple<string, string, string, string, double>(actionValues[i].Item1, actionValues[i].Item2, actionValues[i].Item3,
                      actionValues[i].Item4, value);
                  }
           }
       } 




       public Database()
       {
           // Here we should create an istance of the database and fill it with dummy data while running
           // ex: (but after changing the data structure to fit the new design)

           /*
           SC_Maps.Add("01", new SC_Map());
           actionValues = new List<Tuple<string, string, string, double>>();
           //                          distance, density, avSpeed, value

           actionValues.Add(Tuple.Create("0|100","0.10","60",0.0));
           actionValues.Add(Tuple.Create("0|100","0.20","70",0.0));
           actionValues.Add(Tuple.Create("0|100","0.05","80",0.0));
           actionValues.Add(Tuple.Create("0|100","0.12","50",0.0));
           actionValues.Add(Tuple.Create("0|100","0.15","40",0.0));

           actionValues.Add(Tuple.Create("0|200","0.11","40",0.0));
           actionValues.Add(Tuple.Create("0|200","0.10","60",0.0));
           actionValues.Add(Tuple.Create("0|200","0.13","60",0.0));
           actionValues.Add(Tuple.Create("0|200","0.07","70",0.0));
           actionValues.Add(Tuple.Create("0|200","0.08","90",0.0));

           actionValues.Add(Tuple.Create("0|200","0.10","90",0.0));
           actionValues.Add(Tuple.Create("0|200","0.14","40",0.0));
           actionValues.Add(Tuple.Create("0|200","0.09","20",0.0));
           actionValues.Add(Tuple.Create("0|200","0.04","80",0.0));
           actionValues.Add(Tuple.Create("0|200","0.10","80",0.0));
           */
       }

    }
}
