while (true)
{
    string destination = Console.ReadLine();
    if (destination == "End")
    {
        break;
    }
    double minBudget = double.Parse(Console.ReadLine());
    double savings = 0;

    while (savings < minBudget)
    {
        double income = double.Parse(Console.ReadLine());
        savings += income;
        if (savings >= minBudget)
        {
            Console.WriteLine($"Going to {destination}!");
            break;
        }
    }
}


