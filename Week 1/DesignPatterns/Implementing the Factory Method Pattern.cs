using System;
interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

class ShapeFactory
{
    public IShape GetShape(string shapeType)
    {
        if (shapeType == null)
            return null;

        if (shapeType.Equals("Circle", StringComparison.OrdinalIgnoreCase))
            return new Circle();

        if (shapeType.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
            return new Rectangle();

        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        IShape shape1 = factory.GetShape("Circle");
        shape1.Draw();

        IShape shape2 = factory.GetShape("Rectangle");
        shape2.Draw();
    }
}