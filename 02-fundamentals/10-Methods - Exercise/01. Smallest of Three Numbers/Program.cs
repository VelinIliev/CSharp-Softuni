int[] numbers = new int[] {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};


int FindMinimum(int[] numbers)
{
    int min = int.MaxValue;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }

    return min;
}

Console.WriteLine(FindMinimum(numbers));