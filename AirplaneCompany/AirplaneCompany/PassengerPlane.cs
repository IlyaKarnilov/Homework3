#nullable enable
using System;

namespace AirplaneCompany
{
    public class PassengerPlane: Plane
    {
        public int Seats {private set; get; }

        public PassengerPlane(string model,int fuel, int speed, int seats) : base(model, fuel, speed)
        {
            Seats = seats;
        }

        public override double Range()
        {
            
            double range = (Speed * (Fuel*0.1) - (Seats * 0.1))/54;
            return range;
        }
    }
}