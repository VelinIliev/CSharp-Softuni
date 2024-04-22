Queue<string> queue = new Queue<string>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }

    if (input == "Paid")
    {
        Console.WriteLine(string.Join("\n", queue));
        queue.Clear();
    }
    else
    {
        queue.Enqueue(input);
    }
}

Console.WriteLine($"{queue.Count} people remaining.");