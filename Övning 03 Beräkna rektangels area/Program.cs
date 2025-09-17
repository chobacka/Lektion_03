Console.Write("Ange rektangelns bredd: ");
double bredd = double.Parse(Console.ReadLine()!);

Console.Write("Ange rektangelns höjd: ");
double höjd = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Rektangels area: {bredd * höjd}");