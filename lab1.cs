Console.WriteLine("Введите у: ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите j: ");
double j = double.Parse(Console.ReadLine());
Console.WriteLine($"F={(2 * Math.Sin(0.354 * y + 1)) / Math.Log(y + 2 * j)}");
