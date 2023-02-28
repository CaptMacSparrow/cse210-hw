using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>(); 

        Square s1 = new Square("Blue", 2);
        //square1.GetColor();
        //square1.GetArea();

        //Console.WriteLine($"Color: {square1.GetColor()}. Area: {square1.GetArea()}");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Purple", 2, 3);
        shapes.Add(s2);

        Circle s3 = new Circle("Brown", 5);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"Color: {color}, Area: {area}. ");
        } 
    }
}