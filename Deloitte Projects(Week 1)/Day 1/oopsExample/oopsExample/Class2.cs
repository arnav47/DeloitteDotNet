using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsExample
{
    class Bird : Iflying
    {
        public void fly()
        {
            Console.WriteLine("Flap Flap Flap");
        }
    }

    class Kite : Iflying
    {
        public void fly()
        {
            Console.WriteLine("Flies Colourfully with tail and thread");
        }
    }

    class Plane : Iflying, IPassengerInfo
    {
        public void fly()
        {
            Console.WriteLine("Whooooshhh");
        }

        public void PrintTicket()
        {
            Console.WriteLine("Passenger name: Arnav");
            Console.WriteLine("Other details");
        }
    }
}

