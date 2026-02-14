using System.Diagnostics.Metrics;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Bicecle("Sport", 25));
            vehicles.Add(new Car("BMW M5", 200));
            vehicles.Add(new Airplane("Boeing 737", 800));

            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
            Console.WriteLine();
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car car)
                {
                    car.refill();
                }
                else if (vehicle is Airplane airplane)
                {
                    airplane.refill();
                }
            }
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Task 2:");
            List<Instrument> instruments = new List<Instrument>();

            instruments.Add(new Guitar("Гітара"));
            instruments.Add(new Piano("Піаніно"));
            instruments.Add(new Drums("Барабани"));

            foreach (var instrument in instruments)
            {
                instrument.Play();
            }
            Console.ReadLine();
        }
    }
}
