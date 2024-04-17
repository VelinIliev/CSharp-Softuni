int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int magicNumber = int.Parse(Console.ReadLine());

string pairs = "";

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] + numbers[j] == magicNumber)
        {
            pairs += $"{numbers[i]} {numbers[j]}\n";
        }
    }
}

Console.WriteLine(pairs);