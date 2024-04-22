var regular = new HashSet<string>();
var vips = new HashSet<string>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "PARTY")
    {
        break;
    }

    if (Char.IsDigit(input[0]))
    {
        vips.Add(input);
    }
    else
    {
        regular.Add(input);
    }
    
}

while (true)
{
    string input = Console.ReadLine();
    if (input == "END")
    {
        break;
    }
    if (vips.Contains(input))
    {
        vips.Remove(input);
    } else if (regular.Contains(input))
    {
        regular.Remove(input);
    }
}

Console.WriteLine(vips.Count + regular.Count);
if (vips.Count > 0)
{
    Console.WriteLine(string.Join("\n", vips));
}

if (regular.Count > 0)
{
    Console.WriteLine(string.Join("\n", regular));
}

