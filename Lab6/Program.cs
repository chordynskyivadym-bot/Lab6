namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Bicecle());
            vehicles.Add(new Car());
            vehicles.Add(new Airplane());

            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}
