using System;

namespace UT.Shapes
{
public class Rectangle : IShape
{
    private readonly double _length;
    private readonly double _width;

    public Rectangle(double length, double width)
    {
        if (length <= 0)
            throw new ArgumentException("Length must be positive.", nameof(length));
        if (width <= 0)
            throw new ArgumentException("Width must be positive.", nameof(width));

        _length = length;
        _width = width;
    }

    public double CalculateArea()
    {
        return _length * _width;
    }

    public double CalculateVolume()
    {
        // 2D shape
        return 0;
    }
}
}