﻿string day = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int price = 0;

if (age < 0 || age > 122)
{
    Console.WriteLine("Error!"); 
}
else if (age <= 18)
{
    switch (day)
    {
        case "Weekday": price = 12; break;
        case "Weekend": price = 15; break;
        case "Holiday": price = 5; break;
    }
} else if (age <= 64)
{
    switch (day)
    {
        case "Weekday": price = 18; break;
        case "Weekend": price = 20; break;
        case "Holiday": price = 12; break;
    }
} else if (age <= 122)
{
    switch (day)
    {
        case "Weekday": price = 12; break;
        case "Weekend": price = 15; break;
        case "Holiday": price = 10; break;
    }
}


if (price > 0)
{
    Console.WriteLine($"{price}$");
}