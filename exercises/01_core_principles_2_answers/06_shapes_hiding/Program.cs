using System;

class Shape
{
    public virtual void Describe()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public override void Describe()
    {
        Console.WriteLine("This is a circle.");
    }
}

class Rectangle : Shape
{
    public new void Describe()
    {
        Console.WriteLine("This is a rectangle.");
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle();
        Shape rectangle = new Rectangle();

        circle.Describe();
        rectangle.Describe();

        Console.WriteLine();

        Circle directCircle = new Circle();
        Rectangle directRectangle = new Rectangle();

        directCircle.Describe();
        directRectangle.Describe();
    }
}
