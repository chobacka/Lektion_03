Console.WriteLine("Parallelltrapetsens sidor:");
Console.WriteLine("  a = ");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("  b = ");
double b = double.Parse(Console.ReadLine()!);
Console.WriteLine("  höjd = ");
double h = double.Parse(Console.ReadLine()!);

Console.WriteLine($"parallelltrapetsens area är{(a + b) /2 * h}");