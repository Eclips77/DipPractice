using System;

public interface IShape
{
    int Area();
}

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area()
    {
        return Width * Height;
    }
}

public class Square : IShape
{
    public int Side { get; set; }

    public int Area()
    {
        return Side * Side;
    }
}

