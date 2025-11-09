using NUnit.Framework;
using System;

namespace UT.Calculator.Tests
{
[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Addition_ReturnsCorrectResult()
    {
        var calc = new global::UT.Calculator.Calculator(2, 3, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(5));
    }

    [Test]
    public void Subtraction_ReturnsCorrectResult()
    {
        var calc = new global::UT.Calculator.Calculator(10, 4, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(6));
    }

    [Test]
    public void Multiplication_ReturnsCorrectResult()
    {
        var calc = new global::UT.Calculator.Calculator(3, 5, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(15));
    }

    [Test]
    public void Division_ReturnsCorrectResult()
    {
        var calc = new global::UT.Calculator.Calculator(20, 4, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(5));
    }

    [Test]
    public void Division_AllowsNonIntegerResult()
    {
        var calc = new global::UT.Calculator.Calculator(7, 2, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(3.5));
    }

    [Test]
    public void NegativeNumbers_WorkCorrectly()
    {
        var calc = new global::UT.Calculator.Calculator(-3, -7, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(-10));
    }

    [Test]
    public void ZeroOperand_WorksForAllOperationsExceptDivideByZero()
    {
        var add = new global::UT.Calculator.Calculator(0, 5, '+');
        Assert.That(add.Calculate(), Is.EqualTo(5));

        var sub = new global::UT.Calculator.Calculator(0, 5, '-');
        Assert.That(sub.Calculate(), Is.EqualTo(-5));

        var mul = new global::UT.Calculator.Calculator(0, 5, '*');
        Assert.That(mul.Calculate(), Is.EqualTo(0));
    }

    [Test]
    public void InvalidOperation_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(
            () => new global::UT.Calculator.Calculator(5, 5, '%'));
    }

    [Test]
    public void DivisionByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(
            () => new global::UT.Calculator.Calculator(10, 0, '/'));
    }
}
}
