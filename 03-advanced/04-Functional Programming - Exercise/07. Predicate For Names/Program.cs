int length = int.Parse(Console.ReadLine());

Console.ReadLine()
    .Split()
    .Where(x => x.Length <= length)
    .ToList()
    .ForEach(x => Console.WriteLine(x));
