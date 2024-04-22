string[] input = Console.ReadLine().Split().ToArray();

int totalSum = 0;

int min = Math.Min(input[0].Length, input[1].Length);
int max = Math.Max(input[0].Length, input[1].Length);


for (int i = 0; i < min; i++)
{
    totalSum += (int)input[0][i] * (int)input[1][i];
}

if (min != max) {
    int restIndexes = input[0].Length >= input[1].Length
        ? input[0].Length - input[1].Length
        : input[1].Length - input[0].Length;
    string longerWord = input[0].Length >= input[1].Length ? input[0] : input[1];

    for (int i = min; i < max; i++)
    {
        totalSum += (int)longerWord[i];
    }
}

Console.WriteLine(totalSum);