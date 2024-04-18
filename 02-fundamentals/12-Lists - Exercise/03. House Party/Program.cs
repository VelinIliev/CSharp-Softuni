int lines = int.Parse(Console.ReadLine());

List<string> guests = new List<string>();

for (int i = 0; i < lines; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];

    if (!input.Contains("not"))
    {
        if (guests.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guests.Add(name);
        }
    }
    else
    {
        if (guests.Contains(name))
        {
            guests.Remove(name);
        } 
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

Console.WriteLine(string.Join("\n", guests));