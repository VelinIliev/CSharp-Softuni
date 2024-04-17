string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double CalculatePrice(string product, int quantity)
{
    double total = 0;
    switch (product)
    {
        case "coffee": total = quantity * 1.5; break;
        case "water": total = quantity * 1; break;
        case "coke": total = quantity * 1.4; break;
        case "snacks": total = quantity * 2; break;
    }

    return total;
}

Console.WriteLine($"{CalculatePrice(product, quantity):f2}");