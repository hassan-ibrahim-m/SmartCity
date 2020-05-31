using System;
using System.Collections.Generic;
namespace smartcity
{
    class Report
    {
        private int ID;
        private int tripID;
        string firstEnd, secondEnd;
        double time, distance, density, avSpeed, maxSpeed;
        private Boolean endOfTrip;

        public Report(int ID, int tripID, string firstEnd, string secondEnd, double time, double distance, double density, double avSpeed, double maxSpeed, Boolean endOfTrip)
        {
            this.ID=ID;
            this.tripID=tripID;
            this.firstEnd=firstEnd;
            this.secondEnd=secondEnd;
            this.time=time;
            this.distance=distance;
            this.density=density;
            this.avSpeed=avSpeed;
            this.maxSpeed=maxSpeed;
        }
        public Boolean getIsEnded(){return this.endOfTrip;}
        public int getID(){return this.ID;}
        public int getTripID(){return this.tripID;}
        public string grtFirstEnd(){return this.firstEnd;}
        public string getSecondEnd(){return this.secondEnd;}
        public double getTime(){return this.time;}
        public double getDistance(){return this.distance;}
        public double getDensity(){return this.density;}
        public double getAvSpeed(){return this.avSpeed;}
        public double getMaxSpeed(){return this.maxSpeed;}
    }
}
