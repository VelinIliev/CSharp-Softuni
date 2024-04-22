int lines = int.Parse(Console.ReadLine());

var uniqueNames = new HashSet<string>();

for (int i = 0; i < lines; i++)
{
    string name = Console.ReadLine();
    uniqueNames.Add(name);
}

Console.WriteLine(string.Join("\n", uniqueNames));