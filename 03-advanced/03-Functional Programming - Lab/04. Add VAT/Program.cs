Console.ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .Select(x => x * 1.2)
    .ToList()
    .ForEach(x => Console.WriteLine($"{x:f2}"));