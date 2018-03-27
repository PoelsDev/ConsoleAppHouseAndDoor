using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppHouseAndDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Joske");
            House h1 = new House(200);
            p1.Huis = h1;
            Door d1 = new Door();
            h1.FrontDoor = d1;
            d1.Color = "bruin";

           //Console.WriteLine("{0} woont in een {1} m² groot huis met een voordeur die {2} is.", p1.naam, h1.Area, d1.Color);            

            p1.ShowData();
            h1.ShowData();
            d1.ShowData();
        }
    }
}
