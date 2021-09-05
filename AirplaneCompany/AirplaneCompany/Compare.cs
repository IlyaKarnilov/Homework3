using System;
using System.Collections.Generic;

namespace AirplaneCompany
{
    public class Compare: IComparer<Plane>
    {
        int IComparer<Plane>.Compare(Plane? x, Plane? y)
        {
            return x.Range().CompareTo(y.Range());
        }
    }
    }
