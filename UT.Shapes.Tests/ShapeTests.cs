using NUnit.Framework;
using UT.Shapes;
using System;

namespace UT.Shapes.Tests
{
[TestFixture]
public class SphereTests
{
    [Test]
    public void CalculateArea_ValidRadius_ReturnsCorrectValue()
    {
        var sphere = new Sphere(5);
        var result = sphere.CalculateArea();
        var expected = 4 * Math.PI * 25;
        Assert.That(result, Is.EqualTo(expected).Within(1e-6));
    }

    [Test]
    public void CalculateVolume_ValidRadius_ReturnsCorrectValue()
    {
        var sphere = new Sphere(5);
        var result = sphere.CalculateVolume();
        var expected = (4.0 / 3.0) * Math.PI * 125;
        Assert.That(result, Is.EqualTo(expected).Within(1e-6));
    }

    [Test]
    public void Constructor_NonPositiveRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Sphere(0));
        Assert.Throws<ArgumentException>(() => new Sphere(-1));
    }
}

[TestFixture]
public class CylinderTests
{
    [Test]
    public void CalculateArea_ValidValues_ReturnsCorrectValue()
    {
        var cylinder = new Cylinder(3, 7);
        var result = cylinder.CalculateArea();
        var expected = 2 * Math.PI * 3 * (3 + 7);
        Assert.That(result, Is.EqualTo(expected).Within(1e-6));
    }

    [Test]
    public void CalculateVolume_ValidValues_ReturnsCorrectValue()
    {
        var cylinder = new Cylinder(3, 7);
        var result = cylinder.CalculateVolume();
        var expected = Math.PI * 9 * 7;
        Assert.That(result, Is.EqualTo(expected).Within(1e-6));
    }

    [Test]
    public void Constructor_InvalidValues_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Cylinder(0, 5));
        Assert.Throws<ArgumentException>(() => new Cylinder(-1, 5));
        Assert.Throws<ArgumentException>(() => new Cylinder(3, 0));
        Assert.Throws<ArgumentException>(() => new Cylinder(3, -2));
    }
}

[TestFixture]
public class CubeTests
{
    [Test]
    public void CalculateArea_ValidSide_ReturnsCorrectValue()
    {
        var cube = new Cube(4);
        var result = cube.CalculateArea();
        var expected = 6 * 16;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CalculateVolume_ValidSide_ReturnsCorrectValue()
    {
        var cube = new Cube(4);
        var result = cube.CalculateVolume();
        var expected = 64;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Constructor_InvalidSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Cube(0));
        Assert.Throws<ArgumentException>(() => new Cube(-3));
    }
}

[TestFixture]
public class RectangleTests
{
    [Test]
    public void CalculateArea_ValidValues_ReturnsCorrectValue()
    {
        var rect = new Rectangle(4, 6);
        var result = rect.CalculateArea();
        var expected = 24;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CalculateVolume_AlwaysZero()
    {
        var rect = new Rectangle(4, 6);
        var result = rect.CalculateVolume();
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Constructor_InvalidValues_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(0, 5));
        Assert.Throws<ArgumentException>(() => new Rectangle(-1, 5));
        Assert.Throws<ArgumentException>(() => new Rectangle(5, 0));
        Assert.Throws<ArgumentException>(() => new Rectangle(5, -2));
    }
}
}
