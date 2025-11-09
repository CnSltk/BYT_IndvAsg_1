## Structure
- **UT.Shapes** – Geometric figures library  
- **UT.Shapes.Tests** – Unit tests for geometric figures  
- **UT.Calculator** – Simple arithmetic calculator  
- **UT.Calculator.Tests** – Unit tests for the calculator  

## Part 1 – Shapes
Implements:
- `Sphere`, `Cylinder`, `Cube`, and `Rectangle`
- All classes implement the `IShape` interface  
- Each provides `CalculateArea()` and `CalculateVolume()`  
- Invalid inputs (≤0) throw `ArgumentException`  
- Volume is 0 for 2D shapes  
✅ All tests passed.

## Part 2 – Calculator
- Accepts inputs `A`, `B`, and an operator `[+, -, *, /]`
- Validates input and prevents division by zero  
- Tested for valid, invalid, and edge cases  
✅ All tests passed.

## What is Used
C# · .NET 8.0 · NUnit 
