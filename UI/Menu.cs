using bred.homework.DriversAndVehiclesConsole.services;

namespace bred.homework.DriversAndVehiclesConsole.UI
{
    internal class Menu
    {
        private DriverService _driverService = new();
        private VehicleService _vehicleService = new();

        private string[] MenuCommands = new string[] { "Exit", "Show drivers", "Show vehicles" };

        private void ShowMainMenu() 
        {
            Console.Clear();
            Console.WriteLine("Main menu:");
            for (int i = 0; i < MenuCommands.Length; i++)
            {
                Console.WriteLine($"{i}.{MenuCommands[i]}");
            }

            Console.Write("Enter command plz: ");

            var result = Console.ReadLine() ?? "default";

            DoMainMenu(result);
        }

        public void DoMainMenu(string input) 
        {
            Console.Clear();
            Console.WriteLine($"You enter {input}");

            switch (input)
            {
                case "1":
                    ShowDrivers();
                    break;
                case "2":
                    ShowVehicles();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    ShowMainMenu();
                    break;
            }
        }

        private void ShowDrivers() 
        {
            var drivers = _driverService.GetAllDrivers().ToArray();

            Console.Clear();
            Console.WriteLine("#Id\t#FirstName\t#LastName");

            foreach (var driver in drivers)
            {
                Console.WriteLine($"{driver.Id}\t{driver.FirstName}\t\t{driver.LastName}");
            }

            Console.ReadLine();
            ShowMainMenu();
        }

        private void ShowVehicles()
        {
            var vehicles = _vehicleService.GetAllVehicles().ToArray();

            Console.Clear();
            Console.WriteLine("#Id \t #Name \t\t #Description");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Id} \t {vehicle.Name} \t {vehicle.Description}");
            }

            Console.ReadLine();
            ShowMainMenu();
        }
    }
}
