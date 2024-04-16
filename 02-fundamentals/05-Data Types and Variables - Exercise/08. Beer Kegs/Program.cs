int series = int.Parse(Console.ReadLine());

string biggestKegName = "";
double biggestVolume = 0;

for (int i = 0; i < series; i++)
{
    string name = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * radius * radius * height;

    if (biggestVolume < volume)
    {
        biggestVolume = volume;
        biggestKegName = name;
    }
}

Console.WriteLine(biggestKegName);