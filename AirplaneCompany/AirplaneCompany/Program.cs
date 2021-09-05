using System;
using System.Collections.Generic;

namespace AirplaneCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.PlaneList(company.ListOfPlane);
            company.SortByRange(company.ListOfPlane);
            company.ShowPlane(company.ListOfPlane);
            company.TotalCapasity(company.ListOfPlane);
            company.TotalLoad(company.ListOfPlane);
            company.SearchByFuel(company.ListOfPlane);
        }
        
    }
}