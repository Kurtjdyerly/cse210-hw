using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Red", 5);

        
        Rectangle rectangle1 = new Rectangle("green", 5, 2);

        
        Circle cirlce1 = new Circle("blue", 3);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(cirlce1);
        foreach (Shape shape in shapes)
        {
        Console.WriteLine("The Color is " + shape.GetColor());
        Console.Write("The area is ");
        Console.WriteLine(shape.GetArea());
        }

    }
}