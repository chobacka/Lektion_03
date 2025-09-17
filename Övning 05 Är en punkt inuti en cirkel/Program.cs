Console.WriteLine("Ange punktens koordinater (x, y): ");
Console.Write("  x = ");
double x = double.Parse(Console.ReadLine()!);
Console.Write("  y = ");
double y = double.Parse(Console.ReadLine()!);

bool isInside = x * x + y * y <= 5*5;  // 5 är radien
Console.WriteLine("Punkten ({0}, {1}) {2} inuti cirkeln",
    x, y, isInside? "ÄR" : "ÄR INTE");