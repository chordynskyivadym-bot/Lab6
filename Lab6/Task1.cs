using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public interface IRefuelable
    {
        void reffil();
    }
    abstract class Vehicle
    {
        public string brand;
        public int speed;

        public Vehicle(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public abstract void Move();
    }
    class Car : Vehicle
    {
        public Car(string brand, int speed) : base(brand, speed)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{brand} машина їде зі швидкістю {speed} км/год");
        }
        public void refill()
        {
            Console.WriteLine($"{brand}: заправка бензином або дизельом");
        }
    }
    class Bicecle : Vehicle
    {
        public Bicecle(string brand, int speed) : base(brand, speed)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{brand} велосипед рухається зі швидкістю {speed} км/год");
        }
    }
    class Airplane : Vehicle
    {
        public Airplane(string brand, int speed) : base(brand, speed)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{brand} літак летить зі швидкістю {speed} км/год");
        }
        public void refill()
        {
            Console.WriteLine($"{brand}: заправка авіаційним газом");
        }
    }
}
