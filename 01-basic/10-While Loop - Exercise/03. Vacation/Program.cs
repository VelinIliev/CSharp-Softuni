double moneyNeeded = double.Parse(Console.ReadLine());
double currentMoney = double.Parse(Console.ReadLine());

int spendCount = 0;
int days = 0;

while (true)
{
    string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());
    days += 1;

    if (action == "spend")
    {
        spendCount++;
        currentMoney -= amount;
        if (currentMoney < 0)
        {
            currentMoney = 0;
        }
    } else if (action == "save")
    {
        spendCount = 0;
        currentMoney += amount;
    }

    if (spendCount == 5)
    {
        Console.WriteLine("You can't save the money.");
        Console.WriteLine(days);
        break;
    }

    if (currentMoney >= moneyNeeded)
    {
        Console.WriteLine($"You saved the money for {days} days.");
        break;
    }
}