using System;
using System.Collections.Generic;
namespace smartcity
{
    class Database
    {
       public static List<Tuple<string, string, string, double>> actionValues;
       public static List<Trip> trips;
       public static List<Car> cars = new List<Car>();
       public static IDictionary<string, SC_Map> SC_Maps = new Dictionary<string, SC_Map>();
       public Database()
       {
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

       }
    }
}
