int number = int.Parse(Console.ReadLine());

int[] dividers = {10, 7, 6, 3, 2};
bool notFound = true;

foreach (var n in dividers)
{
    if (number % n == 0)
    {
        Console.WriteLine($"The number is divisible by {n}");
        notFound = false;
        break;
    }
}

if (notFound)
{
    Console.WriteLine("Not divisible");
}