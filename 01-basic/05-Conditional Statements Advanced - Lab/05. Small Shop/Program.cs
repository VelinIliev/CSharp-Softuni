using System.Diagnostics;

string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0.0;

switch (city)
{   
    case "Sofia":
        switch (product)
        {
            case "coffee":
                price = .5;
                break;
            case "water":
                price = .8;
                break;
            case "beer":
                price = 1.2;
                break;
            case "sweets":
                price = 1.45;
                break;
            case "peanuts":
                price = 1.60;
                break;
        }
        break;
    case "Plovdiv":
        switch (product)
        {
            case "coffee":
                price = .4;
                break;
            case "water":
                price = .7;
                break;
            case "beer":
                price = 1.15;
                break;
            case "sweets":
                price = 1.30;
                break;
            case "peanuts":
                price = 1.50;
                break;
        }
        break;
    case "Varna":
        switch (product)
        {
            case "coffee":
                price = .45;
                break;
            case "water":
                price = .7;
                break;
            case "beer":
                price = 1.10;
                break;
            case "sweets":
                price = 1.35;
                break;
            case "peanuts":
                price = 1.55;
                break;
        }
        break;
}

Console.WriteLine(quantity * price);