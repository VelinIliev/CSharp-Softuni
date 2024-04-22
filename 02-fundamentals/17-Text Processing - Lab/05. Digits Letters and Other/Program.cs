string input = Console.ReadLine();

string letters = "";
string numbers = "";
string symbols = "";

foreach (var c in input)
{
    if (Char.IsLetter(c))
    {
        letters += c.ToString();
    } else if (char.IsDigit(c))
    {
        numbers += c.ToString();
    }
    else
    {
        symbols += c.ToString();
    }
}

Console.WriteLine(numbers);
Console.WriteLine(letters);
Console.WriteLine(symbols);