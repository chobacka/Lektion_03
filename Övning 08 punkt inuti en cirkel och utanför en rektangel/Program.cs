using System.Drawing;

Point point = new Point();
Console.WriteLine("Punktens x- och y-koordinater:");
Console.Write("  x = ");
point.x = double.Parse(Console.ReadLine()!);

Console.Write("  y = ");
point.y = double.Parse(Console.ReadLine()!);

if (InsideCircle(point) && !InsideRectangele(point))
{
    Console.WriteLine($"Punkten ({point.x}, {point.y}) ligger innuti cirkeln och utanför rektangeln");
}
else if (!InsideCircle(point) && InsideRectangele(point))
{
    Console.WriteLine($"Punkten ({point.x}, {point.y}) ligger utanför cirkeln och innuti rektangeln");
}
else if (!InsideCircle(point) && !InsideRectangele(point))
{
    Console.WriteLine($"Punkten ({point.x}, {point.y}) ligger utanför cirkeln och utanför rektangeln");
}
else if (InsideCircle(point) && InsideRectangele(point))
{
    Console.WriteLine($"Punkten ({point.x}, {point.y}) ligger innuti cirkeln och innuti rektangeln");
}




static bool InsideCircle(Point point)
 {
  sbyte circleX = 1, circleY = 1, circleRadius = 3;
  point.x = point.x - circleX;
  point.y = point.y - circleY;
  if (point.x * point.x + point.y * point.y <= circleRadius * circleRadius)
  {
    return true;
  }
  else
  {
    return false;
  }

 }

static bool InsideRectangele(Point point)
{
  sbyte rxLeft = -1, ryTop = 1, rxRight = 5, ryBottom = -1;
  if (point.x >= rxLeft && point.x <= rxRight && point.y <= ryTop && point.y >= ryBottom)
  {
    return true;
  }
  else
  {
    return false;
  }
}



public struct Point
{
    public double x;
    public double y;
}