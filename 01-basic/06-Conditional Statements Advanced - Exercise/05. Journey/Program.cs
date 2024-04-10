double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination;
double spendings;
string type;

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        spendings = budget * .3;
        type = "Camp";
    }
    else
    {
        spendings = budget * .7;
        type = "Hotel";
    }
} 
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        spendings = budget * .4;
        type = "Camp";
    }
    else
    {
        spendings = budget * .8;
        type = "Hotel";
    }
}
else
{
    destination = "Europe";
    spendings = budget * .9;
    type = "Hotel";
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{type} - {spendings:f2}");