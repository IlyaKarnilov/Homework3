using System;

namespace AirplaneCompany
{
    public class CargoPlane: Plane
    {
        public int Load {private set; get; }

        public CargoPlane(string model, int fuel, int speed, int load) : base(model, fuel, speed )
        {
            Load = load;
        }
        public override double Range()
        {
            double range = Speed * Fuel / Load * 0.12;
            return range;
        }
    }
}