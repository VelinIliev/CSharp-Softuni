string[] input = Console.ReadLine().Split();

string output = "";

foreach (var word in input)
{
    for (int i = 0; i < word.Length; i++)
    {
        output += word;
    }
}

Console.WriteLine(output);