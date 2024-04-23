List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string input = Console.ReadLine();
    
    if (input == "end")
    {
        break;
    }

    string operation = input;

    Func<int, int> action = operation switch
    {
        "add" => x =>  x + 1,
        "multiply" => x => x * 2,
        "subtract" => x => x - 1,
        _ => null
    };

    if (operation == "print")
    {
        Console.WriteLine(string.Join(" ", numbers));
        continue;
    }

    numbers = numbers.Select(action).ToList();
}

