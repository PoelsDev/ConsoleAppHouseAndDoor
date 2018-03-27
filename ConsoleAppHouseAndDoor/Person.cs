using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppHouseAndDoor
{
    class Person
    {
        public string naam;
        public House Huis { get; set; }

        public Person(string naam)
        {
            this.naam = naam;
        }

        public void ShowData()
        {
            Console.WriteLine("Ik heet {0}.", this.naam);
        }
    }
}
