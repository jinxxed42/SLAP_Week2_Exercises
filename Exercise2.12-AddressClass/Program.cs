namespace Exercise2._12_AddressClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection<Address> myCollection = new();

            Cpr cpr = new("101002", "2005");
            Address address = new("Hejsavej", "72", "1.", "Hejsaby");
            Worker worker = new("Anders Filipsen", address, cpr, "987123");
            myCollection.AddElement(worker.Address, worker);
            Console.WriteLine(myCollection.GetElement(worker.Address).ToString());

            Console.WriteLine();

            cpr = new("010101", "1278");
            address = new("Farvelvej", "27", "Farvelby");
            worker = new("Anette Vistisen", address, cpr, "123987");
            myCollection.AddElement(address, worker);
            Console.WriteLine(myCollection.GetElement(address).ToString());

            Console.WriteLine();

            address = new("Tossetvej", "54", "C/O: Jean-Baptiste Emanuel Zorg", "Horsens");
            Company company = new("Skruer og toiletpapir A/S", address, "98765432");
            myCollection.AddElement(address, company);
            Console.WriteLine(myCollection.GetElement(address).ToString());

            Console.WriteLine();

            Console.WriteLine($"Size is {myCollection.Size()}");

            Console.WriteLine();

            // Some benefits to using an object over a string as key is you can represent a more complex key.
            // Also it is strongly typed. With strings it is fairly easy to input something unwanted.
            // Possibility of creating own comparison logic. Strings are always compared by value.
        }
    }
}