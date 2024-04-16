int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

bool isIdentical = true;
int index = 0;
int sum = 0;

if (array1.Length == array2.Length)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            isIdentical = false;
            index = i;
            break;
        }

        sum += array1[i];
    }
}
else
{
    isIdentical = false;
}

if (isIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
else
{
    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
}