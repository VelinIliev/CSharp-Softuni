string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int jury = int.Parse(Console.ReadLine());


for (int i = 0; i < jury; i++)
{
    string juryName = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());
    double newPoints = (juryName.Length * points) / 2;
    academyPoints += newPoints;
    if (academyPoints > 1250.5)
    {   
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
        break;
    }
}

if (academyPoints <= 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:f1} more!");
}