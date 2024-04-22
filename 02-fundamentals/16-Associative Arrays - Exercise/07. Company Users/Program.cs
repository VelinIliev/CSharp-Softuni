Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

while (true)
{
    string[] info = Console.ReadLine().Split(" -> ").ToArray();

    if (info[0] == "End")
    {
        break;
    }

    string company = info[0];
    string id = info[1];

    if (companies.ContainsKey(company))
    {
        if (!companies[company].Contains(id))
        {
            companies[company].Add(id);
        }
    }
    else
    {
        companies.Add(company, new List<string>());
        companies[company].Add(id);
    }
}

foreach (var company in companies)
{
    Console.WriteLine(company.Key);
    foreach (var id in company.Value)
    {
        Console.WriteLine($"-- {id}");
    }
}