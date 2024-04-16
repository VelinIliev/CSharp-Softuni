int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


if (numbers.Length == 1)
{
    Console.WriteLine(numbers[0]);
}
else
{
    
    int[] condensed = new int[numbers.Length - 1];
    
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < condensed.Length - i; j++)
        {
            condensed[j] = numbers[j] + numbers[j + 1];
        }

        condensed = numbers;
    }
    
    Console.WriteLine(condensed[0]);
}