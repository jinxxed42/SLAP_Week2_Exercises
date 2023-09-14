namespace Exercise2._5_Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new();

            Circle circle = new(12.9, 9.7, 15.0);
            shapes.Add(circle);

            circle = new(1.3, 17.7, 7.1);
            shapes.Add(circle);

            Rectangle rectangle = new(1.7, 2.1, 9.1, 5.7);
            shapes.Add(rectangle);

            rectangle = new(9.1, 7.2, 2.5, 6.1);
            shapes.Add(rectangle);

            foreach (Shape s in shapes)
            {
                Console.WriteLine($"Object is a {s.GetType().Name}.");
                Console.WriteLine($"Coordinates are {s.X} {s.Y}.");

                if (s is Circle circ)
                {
                    Console.WriteLine($"Radius is {circ.Radius}.");
                }
                else if (s is Rectangle rect)
                {
                    Console.WriteLine($"Length is {rect.Length} and Width is {rect.Width}.");
                }
                Console.WriteLine($"Area of object is {s.Area()}.");
                Console.WriteLine("----------------");
            }
        }
    }
}