using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace AirplaneCompany
{
    public class Company
    {
        public List<Plane> ListOfPlane = new List<Plane>();

        public void PlaneList(List<Plane> listOfPlane)
        {
            string path = @"D:\TestReps\AirplaneCompany\Planes.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine())!=null)
                {
                    var newLine = line.Split(' ');
                    if (newLine.Length == 5)
                    {
                        if (newLine[0]=="PP")
                        {
                            listOfPlane.Add(new PassengerPlane(newLine[1],Convert.ToInt32(newLine[2]),Convert.ToInt32(newLine[3]),Convert.ToInt32(newLine[4]) ));
                        }
                        else if (newLine[0]=="CP")
                        {
                            listOfPlane.Add(new CargoPlane(newLine[1], Convert.ToInt32(newLine[2]), Convert.ToInt32(newLine[3]), Convert.ToInt32(newLine[4])));
                        }

                    }
                }
                
            }

        }

        public void SortByRange(List<Plane> list)
        {
            Compare compare = new Compare();
            list.Sort(compare);
        }

        public void ShowPlane(List<Plane> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine($"{i.GetType()} {i.Model} Range: {i.Range()}");
            }
        }

        public void TotalCapasity(List<Plane> list)
        {
            var capasity = 0;
            foreach (var plane in list)
            {
                if (plane is PassengerPlane)
                {
                    var passengerPlane = plane as PassengerPlane;
                    capasity += passengerPlane.Seats;
                }
            }
            Console.WriteLine($"Total capasity = {capasity}");
        }
        public void TotalLoad(List<Plane> list)
        {
            var load = 0;
            foreach (var plane in list)
            {
                if (plane is CargoPlane)
                {
                    var cargoPlane = plane as CargoPlane;
                    load += cargoPlane.Load;
                }
            }
            Console.WriteLine($"Total capasity = {load} ton");
        }
        public void SearchByFuel(List<Plane> list)
        {
            Console.WriteLine("Enter min");
            int min = 0;
            while (!Int32.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Incorrect value");
            }
            int max = 0;
            while (!Int32.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("Incorrect value");
            }

            var selectedPlane = from plane in list
                where plane.Fuel > min && plane.Fuel < max
                select plane;
            foreach (var plane in selectedPlane)
            {
                Console.WriteLine($"{plane.Model}");
            }
        }
    }
}