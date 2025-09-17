Console.Write("Ange ett heltal: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Talet {0} är delbart med 5 och 7 samtidigt: {1}"
    , number, number % 35 == 0);