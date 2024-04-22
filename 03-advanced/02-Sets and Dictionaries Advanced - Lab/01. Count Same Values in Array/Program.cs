List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

Dictionary<double, int> counts = new Dictionary<double, int>();

foreach (var number in numbers)
{
    if (counts.ContainsKey(number))
    {
        counts[number] += 1;
    }
    else
    {
        counts.Add(number, 1);
    }
}

foreach (var c in counts)
{
    Console.WriteLine($"{c.Key} - {c.Value} times");
}