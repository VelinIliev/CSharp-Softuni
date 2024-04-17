string input = Console.ReadLine();

int CountVowels(string input)
{
    int count = 0;
    char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I'};
    foreach (var currentChar in input)
    {
        if (vowels.Contains(currentChar))
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine(CountVowels(input));