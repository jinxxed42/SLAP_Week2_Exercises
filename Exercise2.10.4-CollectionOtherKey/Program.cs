namespace Exercise2._10._4_CollectionOtherKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection<string> myCollection = new();

            Cpr cpr = new("101002", "2005");
            Worker worker = new("Anders Filipsen", "Hejsavej 72, Hejsaby", cpr, "987123");
            myCollection.AddElement("987123", worker);

            cpr = new("010101", "1278");
            worker = new("Anette Vistisen", "Farvelvej 27, Farvelby", cpr, "123987");
            myCollection.AddElement("123987", worker);

            worker = myCollection.GetElement("987123");
            if (worker == null)
            {
                Console.WriteLine("Null reference.");
            }
            else Console.WriteLine(worker.ToString()); // Should be Anders Filipsen, and works

            Console.WriteLine();

            worker = myCollection.GetElement("123987");
            if (worker == null)
            {
                Console.WriteLine("Null reference.");
            }
            else Console.WriteLine(worker.ToString()); // Should be Anette Vistisen, and works

            Console.WriteLine();

            Console.WriteLine($"Size is {myCollection.Size()}");

            Console.WriteLine();

            Console.WriteLine("Works because strings are compared by value even though they are reference types.");
        }
    }
}