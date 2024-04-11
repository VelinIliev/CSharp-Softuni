int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int volume = width * height * length;

while (true)
{
    string input = Console.ReadLine();
    if (input == "Done")
    {
        break;
    }

    volume -= int.Parse(input);

    if (volume <= 0)
    {
        break;
    }
}

if (volume >= 0)
{
    Console.WriteLine($"{volume} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
}