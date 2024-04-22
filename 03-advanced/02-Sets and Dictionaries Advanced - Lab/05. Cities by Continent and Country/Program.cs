int lines = int.Parse(Console.ReadLine());

var continets = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < lines; i++)
{
    string[] info = Console.ReadLine().Split().ToArray();
    string continent = info[0];
    string country = info[1];
    string town = info[2];

    if (!continets.ContainsKey(continent))
    {
        continets.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!continets[continent].ContainsKey(country))
    {
        continets[continent].Add(country, new List<string>());
    }
    continets[continent][country].Add(town);
}

foreach (var c in continets)
{
    Console.WriteLine($"{c.Key}:");
    foreach (var country in c.Value)
    {
        Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value )}");
    }
}