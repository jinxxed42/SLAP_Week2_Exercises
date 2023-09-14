namespace Exercise2._10._3_CollectionWithHashcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection<Cpr> myCollection = new();

            Cpr cpr = new("101002", "2005");
            Worker worker = new("Anders Filipsen", "Hejsavej 72, Hejsaby", cpr, "987123");
            myCollection.AddElement(worker.Cpr, worker);
            Console.WriteLine(myCollection.GetElement(cpr).ToString());

            Console.WriteLine();

            cpr = new("010101", "1278");
            worker = new("Anette Vistisen", "Farvelvej 27, Farvelby", cpr, "123987");
            myCollection.AddElement(worker.Cpr, worker);
            Console.WriteLine(myCollection.GetElement(cpr).ToString());

            Console.WriteLine();

            Console.WriteLine($"Size is {myCollection.Size()}");

            Console.WriteLine();

            Console.WriteLine("---------------");

            Console.WriteLine("Showing when Equals/GetHashCode is needed.");

            Console.WriteLine();

            myCollection = new();

            cpr = new("101002", "2005");
            worker = new("Anders Filipsen", "Hejsavej 72, Hejsaby", cpr, "987123");
            myCollection.AddElement(worker.Cpr, worker);

            cpr = new("010101", "1278");
            worker = new("Anette Vistisen", "Farvelvej 27, Farvelby", cpr, "123987");
            myCollection.AddElement(worker.Cpr, worker);

            cpr = new("101002", "2005");
            worker = myCollection.GetElement(cpr);
            if (worker == null)
            {
                Console.WriteLine("Null reference.");
            }
            else Console.WriteLine(worker.ToString()); // Should be Anders Filipsen, and it is

            Console.WriteLine();

            cpr = new("010101", "1278");
            worker = myCollection.GetElement(cpr);
            if (worker == null)
            {
                Console.WriteLine("Null reference.");
            }
            else Console.WriteLine(worker.ToString()); // Should be Anette Vistisen, and it is

            Console.WriteLine();

            Console.WriteLine($"Size is {myCollection.Size()}");

            Console.WriteLine();

            Console.WriteLine("Using new Cpr objects so the references are no longer equal and therefore the values can't be found in the collection.");
            Console.WriteLine("Even when adding Equals because Dictionary is a hash-based datastructure.");
            Console.WriteLine("However now by using GetHashcode as well it works.");
        }
    }
}