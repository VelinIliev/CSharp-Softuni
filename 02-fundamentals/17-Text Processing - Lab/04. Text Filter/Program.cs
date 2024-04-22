string[] banned = Console.ReadLine().Split(", ");


string text = Console.ReadLine();

foreach (var word in banned)
{
    string replacment = "";
    for (int i = 0; i < word.Length; i++)
    {
        replacment += "*";
    }
    while (text.Contains(word))
    {
        text = text.Replace(word, replacment);
    }
}

Console.WriteLine(text);