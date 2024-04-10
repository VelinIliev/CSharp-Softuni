
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double price;

if (season == "Spring")
{
    price = 3000;
} else if (season == "Summer" || season == "Autumn")
{
    price = 4200;
} else 
{
    price = 2600;
}

if (fishermen <= 6)
{
    price *= 0.9;
} else if (fishermen <= 11)
{
    price *= .85;
}
else 
{
    price *= .75;
}

if (fishermen % 2 == 0 && season != "Autumn")
{
    price *= .95;
}

if (budget >= price)
{
    Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
}