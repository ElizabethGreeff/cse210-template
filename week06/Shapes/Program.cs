using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Orange", 4, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Pink", 6);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string colour = shape.GetColour();

            double area = shape.GetArea();

            Console.WriteLine($"The {colour} shape has an area of {area}");
            
        }
    }
}