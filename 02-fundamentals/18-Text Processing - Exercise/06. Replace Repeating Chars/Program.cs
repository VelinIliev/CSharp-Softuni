string input = Console.ReadLine();

for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] == input[i + 1])
    {
        input = input.Remove(i, 1);
        i = -1;
    }
}

Console.WriteLine(input);