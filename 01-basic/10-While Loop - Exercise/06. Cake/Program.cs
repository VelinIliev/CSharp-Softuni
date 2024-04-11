int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int cakeSize = width * height;

while (true)
{
    string input = Console.ReadLine();
    if (input == "STOP")
    {
        break;
    }

    cakeSize -= int.Parse(input);
    if (cakeSize <= 0)
    {
        break;
    }
}

if (cakeSize >= 0)
{
    Console.WriteLine($"{cakeSize} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
}