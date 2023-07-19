using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        // Using Heron's formula to calculate the area of a triangle
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Triangle triangle = new Triangle(3, 4, 5);

        Shape[] shapes = { circle, rectangle, triangle };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}");
            Console.WriteLine($"Area: {shape.CalculateArea()}");
            Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
            Console.WriteLine();
        }
    }
}
