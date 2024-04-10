string month = Console.ReadLine();
int sleepsCount = int.Parse(Console.ReadLine());

double studioPrice = 0;
double appartmentPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = 50;
    appartmentPrice = 65;
    if (sleepsCount > 7 && sleepsCount <= 14)
    {
        studioPrice *= .95;
    } 
    else if (sleepsCount > 14)
    {
        studioPrice *= .7;
    }
}
else if (month == "June" || month == "September")
{
    studioPrice = 75.2;
    appartmentPrice = 68.7;
    if (sleepsCount > 14)
    {
        studioPrice *= .8;
    } 
}
else if (month == "July" || month == "August")
{
    studioPrice = 76;
    appartmentPrice = 77;
}

if (sleepsCount > 14)
{
    appartmentPrice *= .9;
}

Console.WriteLine($"Apartment: {sleepsCount * appartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {sleepsCount * studioPrice:f2} lv.");