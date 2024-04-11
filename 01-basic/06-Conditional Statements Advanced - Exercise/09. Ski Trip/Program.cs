double roomPrice = 18;
double apartmentPrice = 25;
double presidentAprartmentPrice = 35;

int sleeps = int.Parse(Console.ReadLine()) - 1;
string type = Console.ReadLine();
string rating = Console.ReadLine();

if (sleeps < 10)
{
    apartmentPrice *= .7;
    presidentAprartmentPrice *= .9;
} 
else if (sleeps <= 15)
{
    apartmentPrice *= .65;
    presidentAprartmentPrice = .85;
} else if (sleeps > 15)
{
    apartmentPrice *= .5;
    presidentAprartmentPrice *= .8;
}

double totalPrice = 0;

if (type == "room for one person")
{
    totalPrice = roomPrice * sleeps;
} else if (type == "apartment")
{
    totalPrice = apartmentPrice * sleeps;
} else if (type == "president apartment")
{
    totalPrice = presidentAprartmentPrice * sleeps;
}

if (rating == "positive")
{
    totalPrice *= 1.25;
} else if (rating == "negative")
{
    totalPrice *= .9;
}

Console.WriteLine($"{totalPrice:f2}");