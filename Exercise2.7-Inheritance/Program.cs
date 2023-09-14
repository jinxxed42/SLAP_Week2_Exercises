namespace Exercise2._7_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mechanic mechanic = new("John Svendsen", "Vejlevej 123, Vejle", 1972, 272.7);
            Console.WriteLine("Mechanic: " + mechanic.ToString());

            Console.WriteLine();

            mechanic.Name = "Lars Boesen";
            mechanic.Address = "Horsensvej 321, Horsens";
            mechanic.JourneymanYear = 2015;
            mechanic.HourlyWage = 205.41;
            Console.WriteLine("Mechanic: " + mechanic.ToString());

            Console.WriteLine();

            Foreman foreman = new("Lars Petersen", "Envej 92, Enby", 2000, 291.2, 2010, 15.2);
            Console.WriteLine("Foreman: " + foreman.ToString());

            Console.WriteLine();

            foreman.Name = "Lisbeth Petersen";
            foreman.Address = "Enandenvej 29, Enandenby";
            foreman.JourneymanYear = 2001;
            foreman.HourlyWage = 297.5;
            foreman.AppointmentYear = 2011;
            foreman.Bonus = 17.9;
            Console.WriteLine("Foreman: " + foreman.ToString());

            Console.WriteLine();

            VehicleInspector vehicleInspector = new("Ulla Terkildsen", "Cypresvej 14, Bjerringbro", 1999, 281.72, 35);
            Console.WriteLine("Vehicle inspector: " + vehicleInspector.ToString());

            Console.WriteLine();

            vehicleInspector.Name = "Lillian Andersen";
            vehicleInspector.Address = "Vej 123, By";
            vehicleInspector.JourneymanYear = 1992;
            vehicleInspector.HourlyWage = 279.1;
            vehicleInspector.Inspections = 30;

            Console.WriteLine("Vehicle inspector: " + vehicleInspector.ToString());
        }
    }
}