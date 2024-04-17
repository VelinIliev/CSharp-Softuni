string input = Console.ReadLine();

static void PrintMiddleCharacters(string input)
{
    if (input.Length % 2 == 0)
    {
        int middle = input.Length / 2 - 1;
        Console.WriteLine($"{input[middle]}{input[middle + 1]}");
    }
    else
    {
        int middle = (input.Length - 1) / 2;
        Console.WriteLine($"{input[middle]}");
    }
}

PrintMiddleCharacters(input);