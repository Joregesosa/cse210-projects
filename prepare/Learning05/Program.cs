using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Circle circle = new Circle("Blue", 7);
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle("White", 4, 8);
        shapes.Add(rectangle);

        Square square = new Square("Red", 5);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The " + shape.GetColor() + " shape has an area of " + shape.GetArea() + ".");
        }
    }
}