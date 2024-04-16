int lines = int.Parse(Console.ReadLine());

for (int i = 0; i < lines; i++)
{
    string[] input = Console.ReadLine().Split(" ");

    long left = long.Parse(input[0]);
    long right = long.Parse(input[1]);
    
    long number = left > right ? left : right;
    
    Console.WriteLine($"{FindSum(number)}");
    
}

long FindSum (long number)
{
    long sum = 0;
    while (number != 0 )
    {
        sum += number % 10;
        number /= 10;
    }

    return Math.Abs(sum);
}
