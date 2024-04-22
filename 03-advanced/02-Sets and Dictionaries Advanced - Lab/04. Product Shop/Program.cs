var magazines =  new SortedDictionary<string, Dictionary<string, double>>();


while (true)
{
    string input = Console.ReadLine();

    if (input == "Revision")
    {
        break;
    }

    string[] info = input.Split(", ").ToArray();
    string magazin = info[0];
    string product = info[1];
    double price = double.Parse(info[2]);

    if (magazines.ContainsKey(magazin))
    {
        if (!magazines[magazin].ContainsKey(product))
        {
            magazines[magazin].Add(product, price);
        }
    }
    else
    {
        magazines.Add(magazin, new Dictionary<string, double>());
        magazines[magazin].Add(product, price);
    }
}

foreach (var m in magazines)
{
    Console.WriteLine($"{m.Key}->");
    foreach (var p in m.Value)
    {
        Console.WriteLine($"Product: {p.Key}, Price: {p.Value}");
    }
}