int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

bool isEqual = false;

for (int i = 0; i < numbers.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;
    
    for (int j = 0; j < i; j++)
    {
        leftSum += numbers[j];
    }

    for (int k = i + 1; k < numbers.Length; k++)
    {
        rightSum += numbers[k];
    }

    if (leftSum == rightSum)
    {
        Console.WriteLine(i);
        isEqual = true;
        break;
    }
}

if (!isEqual)
{
    Console.WriteLine("no");
}