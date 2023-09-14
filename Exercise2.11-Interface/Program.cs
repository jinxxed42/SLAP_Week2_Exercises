namespace Exercise2._11_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection<string> myCollection = new();

            Cpr cprNr = new("101002", "2005");
            Worker worker = new("Anders Filipsen", "Hejsavej 72, Hejsaby", cprNr, "987123");
            myCollection.AddElement("Hejsavej 72, Hejsaby", worker);
            Console.WriteLine(myCollection.GetElement("Hejsavej 72, Hejsaby").ToString());

            Console.WriteLine();

            cprNr = new("010101", "1278");
            worker = new("Anette Vistisen", "Farvelvej 27, Farvelby", cprNr, "123987");
            myCollection.AddElement("Farvelvej 27, Farvelby", worker);
            Console.WriteLine(myCollection.GetElement("Farvelvej 27, Farvelby").ToString());

            Console.WriteLine();

            Company company = new("Skruer og toiletpapir A/S", "Tossetvej 54, Horsens", "98765432");
            myCollection.AddElement("Tossetvej 54, Horsens", company);
            Console.WriteLine(myCollection.GetElement("Tossetvej 54, Horsens").ToString());

            Console.WriteLine();

            Console.WriteLine($"Size is {myCollection.Size()}");

            Console.WriteLine();

        }
    }
}