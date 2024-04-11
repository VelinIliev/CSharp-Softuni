int numberOfTournements = int.Parse(Console.ReadLine());
int points = int.Parse(Console.ReadLine());
int toutnementPoints = 0;
int wonTournements = 0;

for (int i = 0; i < numberOfTournements; i++)
{
    string position = Console.ReadLine();
    
    if (position == "W")
    {
        points += 2000;
        toutnementPoints += 2000;
        wonTournements++;
    } else if (position == "F")
    {
        points += 1200;
        toutnementPoints += 1200;
    } else if (position == "SF")
    {
        points += 720;
        toutnementPoints += 720;
    }
}

Console.WriteLine($"Final points: {points}");
Console.WriteLine($"Average points: {toutnementPoints/numberOfTournements}");
Console.WriteLine($"{(double)wonTournements/numberOfTournements*100:f2}%");