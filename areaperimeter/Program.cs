using System;

class Shape
{
    public virtual double GetArea() { return 0; }
    public virtual double GetPerimeter() { return 0; }
}

class Triangle : Shape
{
    double a, b, c;

    public Triangle(double side1, double side2, double side3)
    {
        a = side1;
        b = side2;
        c = side3;
    }

    public override double GetArea()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public override double GetPerimeter()
    {
        return a + b + c;
    }
}

class Square : Shape
{
    double side;

    public Square(double s)
    {
        side = s;
    }

    public override double GetArea()
    {
        return side * side;
    }

    public override double GetPerimeter()
    {
        return 4 * side;
    }
}

class Rectangle : Shape
{
    double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double GetArea()
    {
        return length * width;
    }

    public override double GetPerimeter()
    {
        return 2 * (length + width);
    }
}

class Circle : Shape
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Triangle t = new Triangle(3, 4, 5);
        Console.WriteLine("Area of Triangle: {0}", t.GetArea());
        Console.WriteLine("Perimeter of Triangle: {0}", t.GetPerimeter());

        Square s = new Square(5);
        Console.WriteLine("Area of Square: {0}", s.GetArea());
        Console.WriteLine("Perimeter of Square: {0}", s.GetPerimeter());

        Rectangle r = new Rectangle(4, 6);
        Console.WriteLine("Area of Rectangle: {0}", r.GetArea());
        Console.WriteLine("Perimeter of Rectangle: {0}", r.GetPerimeter());

        Circle c = new Circle(3);
        Console.WriteLine("Area of Circle: {0}", c.GetArea());
        Console.WriteLine("Circumference of Circle: {0}", c.GetPerimeter());

        Console.ReadKey();
    }
}
