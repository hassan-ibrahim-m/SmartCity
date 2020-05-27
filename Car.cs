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
    }
}
