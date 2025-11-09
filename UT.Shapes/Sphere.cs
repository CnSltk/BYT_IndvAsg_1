using System;

namespace UT.Shapes;

public class Sphere : IShape
{
    private readonly double _radius;

    public Sphere(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive.", nameof(radius));

        _radius = radius;
    }

    public double CalculateArea()
    {
        return 4 * Math.PI * Math.Pow(_radius, 2);
    }

    public double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }
}