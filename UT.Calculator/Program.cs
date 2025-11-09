using System;

namespace UT.Calculator
{
internal class Program
{
    static void Main(string[] args)
    {
        // Simple demo usage for the assignment

        var add = new Calculator(10, 5, '+');
        Console.WriteLine($"10 + 5 = {add.Calculate()}");

        var sub = new Calculator(10, 5, '-');
        Console.WriteLine($"10 - 5 = {sub.Calculate()}");

        var mul = new Calculator(10, 5, '*');
        Console.WriteLine($"10 * 5 = {mul.Calculate()}");

        var div = new Calculator(10, 5, '/');
        Console.WriteLine($"10 / 5 = {div.Calculate()}");
        
        var invalidOp = new Calculator(10, 5, '%'); // throws ArgumentException
        var divByZero = new Calculator(10, 0, '/'); // throws DivideByZeroException
    }
}
}