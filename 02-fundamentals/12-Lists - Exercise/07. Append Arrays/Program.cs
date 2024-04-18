string input = Console.ReadLine();

List<string> firstSplit = input.Split("|").Reverse().ToList();

List<string> result = new List<string>();

foreach (var item in firstSplit)
{
    result.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
}

Console.WriteLine(string.Join(" ", result));