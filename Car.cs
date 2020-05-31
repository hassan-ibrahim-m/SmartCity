using System;
using System.Collections.Generic;
namespace smartcity
{
    class Car
    {
        private int tripID=-1;
        int id;
        public Car(int id)   
        {
            this.id=id;
        }     
        public bool isOnTrip()
        {
            if(tripID==-1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public int getCurrentTrip()
        {
            return this.tripID;
        }
        public void setTripID(int tripID)
        {
            this.tripID=tripID;
        }
        public void move(List<Node> route)
        {
            string firstEnd, secondEnd;
            double time, distance, density, avSpeed, maxSpeed;
            for(int i=0;i<route.Count; i++)
            {
                // Move the ith edge
                // after finishing the edge, send the data in a report to the agnet
                // the data are:

                firstEnd="";
                secondEnd="";
                time =0.0; // time = get from us
                distance=0.0;
                density=0.0;
                avSpeed=0.0;
                maxSpeed=0.0;
                Report report;
                if(i==route.Count-1)
                {
                    report = new Report(id, tripID, firstEnd, secondEnd, time, distance, density, avSpeed, maxSpeed, true);
                }
                else
                {
                    report = new Report(id, tripID, firstEnd, secondEnd, time, distance, density, avSpeed, maxSpeed, false);
                }
                Agent.updateValue(report);
            }
        }
    }
}
