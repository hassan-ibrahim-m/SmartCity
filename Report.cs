using System;
using System.Collections.Generic;
namespace smartcity
{
    class Report
    {
        private int ID;
        private int tripID;
        private Tuple<string, string, double, double, double, double> edgeData;
        // Tuple<"firstEnd", "secondEnd", time, avarageSpeed, density, distance>
        private Boolean isEnded;

        public void setEdgeData(string firstEnd, string secondEnd, double time, double avarageSpeed, double density, double distance)
        {
            this.edgeData = new Tuple<string, string, double, double, double, double>(firstEnd, secondEnd, time, avarageSpeed, density, distance);
        }

        public Tuple<string, string, double, double, double, double> getEdgeData()
        {
            return this.edgeData;
        }
        public Report(int ID, int tripID, Tuple<string, string, double, double, double, double> edgeData, Boolean isEnded)
        {
            this.ID=ID;
            this.tripID=tripID;
            this.edgeData=edgeData;
            this.isEnded=isEnded;
        }
        public Boolean getIsEnded(){return isEnded;}
    }
}
