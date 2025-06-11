using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        //List of shapes
        List<Shape> shapes = new List<Shape>();
        //Square
        Square square = new Square("Red", 34);
        //Rectangle
        Rectangle rectangle = new Rectangle("Bleu", 12,34);
        //Circle
        Circle circle = new Circle("Green", 25);
        // Add all shapes to the list 
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        //Display all information in shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
      



        Console.ReadLine();
    }
}