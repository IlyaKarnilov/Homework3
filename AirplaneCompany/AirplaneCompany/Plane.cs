using System;

namespace AirplaneCompany
{
    public class Plane
    {
        public int Fuel {private set; get; }
        public int Speed {private set; get; }
        public string Model {private set; get; }

        public Plane(string model, int fuel, int maxSpeed)
        {
            Model = model;
            Fuel = fuel;
            Speed = maxSpeed;
        }

        public virtual double Range()
        {
            double range = 0;
            return range;
        }
        
        public static int CompareByRange(Plane plane1, Plane plane2)
        {
            return plane1.Range().CompareTo(plane2);
        }
    }
}