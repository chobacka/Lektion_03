Console.Write("Ange ett heltal(större än 99): ");
int number = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Tredje siffran i {number} är 7: {number /100 % 10 == 7}");