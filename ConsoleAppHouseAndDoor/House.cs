using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppHouseAndDoor
{
    class House
    {
        public int Area { get; set; }
        public Door FrontDoor { get; set; }

        public House(int area)
        {
            this.Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine("Mijn huis is {0} m² groot.",this.Area);
        }
    }
}
