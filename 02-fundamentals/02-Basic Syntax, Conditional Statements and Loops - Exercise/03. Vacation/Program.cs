int people = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;

switch (groupType)
{
    case "Students":
        switch (day)
        {
            case "Friday": price = 8.45; break;
            case "Saturday": price = 9.80; break;
            case "Sunday": price = 10.46; break;
        }

        if (people >= 30)
        {
            price *= .85;
        }
        break;
    case "Business":
        switch (day)
        {
            case "Friday": price = 10.90; break;
            case "Saturday": price = 15.60; break;
            case "Sunday": price = 16.00; break;
        } 
        if (people >= 100)
        {
            people -= 10;
        }
        break;
    case "Regular":
        switch (day)
        {
            case "Friday": price = 15; break;
            case "Saturday": price = 20; break;
            case "Sunday": price = 22.50; break;
        } 
        if (people >= 10 && people <= 20)
        {
            price *= .95;
        }
        break;
}

Console.WriteLine($"Total price: {people * price:f2}");