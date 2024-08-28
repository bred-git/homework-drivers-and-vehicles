using bred.homework.DriversAndVehiclesConsole.models;

namespace bred.homework.DriversAndVehiclesConsole.services
{
    internal class VehicleService
    {
        private List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle(1, "Shustrik", "Ochen bistriy"),
            new Vehicle(2, "Gryazniy", "Materniy"),
            new Vehicle(3, "Krasavchick", "Krasiviy voobshe da")
        };

        private static int idCounter = 4;

        public List<Vehicle> GetAllVehicles() 
        {
            return vehicles;
        }

        public void AddVehicle(string name, string description) 
        { 
            Vehicle vehicle = new Vehicle(idCounter++, name, description);
            vehicles.Add(vehicle);
        }
    }
}
