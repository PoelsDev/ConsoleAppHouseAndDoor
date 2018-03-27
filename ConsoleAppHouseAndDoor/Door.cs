using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppHouseAndDoor
{
    class Door
    {
        public string Color { get; set; }

        public void ShowData()
        {
            Console.WriteLine("De voordeur is " + this.Color +".");
        }
    }
}
