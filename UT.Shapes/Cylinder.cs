using System;

namespace UT.Shapes
{
public class Cylinder : IShape
{
    private readonly double _radius;
    private readonly double _height;

    public Cylinder(double radius, double height)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive.", nameof(radius));
        if (height <= 0)
            throw new ArgumentException("Height must be positive.", nameof(height));

        _radius = radius;
        _height = height;
    }

    public double CalculateArea()
    {
        // Total surface area = 2πr(h + r)
        return 2 * Math.PI * _radius * (_radius + _height);
    }

    public double CalculateVolume()
    {
        // Volume = πr²h
        return Math.PI * Math.Pow(_radius, 2) * _height;
    }
}
}