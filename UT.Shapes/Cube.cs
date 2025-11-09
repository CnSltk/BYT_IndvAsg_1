using System;

namespace UT.Shapes
{
public class Cube : IShape
{
    private readonly double _side;

    public Cube(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Side must be positive.", nameof(side));

        _side = side;
    }

    public double CalculateArea()
    {
        // 6a²
        return 6 * Math.Pow(_side, 2);
    }

    public double CalculateVolume()
    {
        // a³
        return Math.Pow(_side, 3);
    }
}
}