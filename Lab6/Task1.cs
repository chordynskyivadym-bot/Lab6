using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class Vehicle
    {
        public string brand;
        public int speed;

        public abstract void Move();
    }
    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"The {brand} car is moving at {speed} km/h.");
        }
    }
    class Bicecle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"The {brand} bicycle is moving at {speed} km/h.");
        }
    }
    class Airplane : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"The {brand} airplane is flying at {speed} km/h.");
        }
    }
}
