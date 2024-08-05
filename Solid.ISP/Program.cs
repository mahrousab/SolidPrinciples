// Before Using SIP Principle
/*
using Solid.ISP.Before;

IMath math = new BasicMath();

Console.WriteLine("Even: " + math.Even(2, 2));
Console.WriteLine("Odd: " + math.Odd(1, 2));
Console.WriteLine("Sum: " + math.Sum(1, 2,3,4,5));
Console.WriteLine("Min: " + math.Min(1, 2,3,4,5));
Console.WriteLine("Odd: " + math.Max(1, 2,3,4,5));

*/

using Solid.ISP.After;

IBasicMath math = new BasicMath();

Console.WriteLine("Sum: " + math.Sum(1, 2, 3, 4, 5));
Console.WriteLine("Min: " + math.Min(1, 2, 3, 4, 5));
Console.WriteLine("Max: " + math.Max(1, 2, 3, 4, 5));


AdvancedMath advanced = new AdvancedMath();
Console.WriteLine("Even: " + advanced.IsEven(2, 2));
Console.WriteLine("Odd: " + advanced.IsOdd(1, 2));


