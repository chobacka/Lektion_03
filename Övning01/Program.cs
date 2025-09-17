Console.Write("Ange ett heltal: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Talet {0} är {1}", number, number % 2 == 0 ? "jämnt" : "udda");