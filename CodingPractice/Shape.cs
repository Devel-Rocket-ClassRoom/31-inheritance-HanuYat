using System;

abstract class Shape
{
    public string Name;

    public abstract double GetArea();
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public override double GetArea()
    {
        return (Width * Height);
    }
}

class Circle : Shape
{
    public double Radius;

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}