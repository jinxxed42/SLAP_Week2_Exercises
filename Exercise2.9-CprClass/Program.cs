namespace Exercise2._9_CprClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new("Anders Filipsen", "Hejsavej 72, Hejsaby", new Cpr("101002", "2005"), "987123");
            Console.WriteLine(worker.ToString());

            Console.WriteLine();

            worker = new("Anette Vistisen", "Farvelvej 27, Farvelby", new Cpr("010101", "1278"), "123987");
            Console.WriteLine(worker.ToString());

        }
    }
}