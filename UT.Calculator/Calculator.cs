using System;

namespace UT.Calculator
{
public class Calculator
{
    public double A { get; }
    public double B { get; }
    public char Operation { get; }

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;

        Validate();
    }

    private void Validate()
    {
        if (Operation != '+' && Operation != '-' && Operation != '*' && Operation != '/')
            throw new ArgumentException("Invalid operation. Allowed: +, -, *, /", nameof(Operation));

        if (Operation == '/' && B == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
    }

    public double Calculate()
    {
        return Operation switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' => A / B,
            _   => throw new InvalidOperationException("Unsupported operation.")
        };
    }
}
}