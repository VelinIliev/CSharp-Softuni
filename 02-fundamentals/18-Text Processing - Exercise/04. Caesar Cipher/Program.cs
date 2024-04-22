string input = Console.ReadLine();

string message = "";


foreach (var c in input)
{
    message += (char)((int)c + 3);
}

Console.WriteLine(message);