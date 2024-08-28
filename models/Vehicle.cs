namespace bred.homework.DriversAndVehiclesConsole.models
{
    internal class Vehicle
    {
        public Vehicle(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
    }
}
