int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    bool isGreater = true;
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] <= numbers[j])
        {
            isGreater = false;
            break;
        }
    }

    if (isGreater)
    {
        Console.Write(numbers[i] + " ");
    }
}