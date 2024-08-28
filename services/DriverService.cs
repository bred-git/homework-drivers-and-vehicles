using bred.homework.DriversAndVehiclesConsole.models;

namespace bred.homework.DriversAndVehiclesConsole.services
{
    public class DriverService
    {
        private List<Driver> drivers = new List<Driver> 
        {
            new Driver(1, "Ashot", "Ashotov"),
            new Driver(2, "Strelba", "Enotov"),
            new Driver(3, "Voina", "Zaglotov")
        };

        private static int idCounter = 4;

        public List<Driver> GetAllDrivers() {
            return drivers;
        }

        public void AddDriver(string firstName, string lastName)
        {
            Driver driver = new Driver(idCounter++, firstName, lastName);
            drivers.Add(driver);
        }
    }
}
