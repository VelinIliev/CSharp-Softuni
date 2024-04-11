double balance = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == "NoMoreMoney")
    {
        break;
    }

    double amount = double.Parse(input);
    
    if (amount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    else
    {
        Console.WriteLine($"Increase: {amount:f2}");
        balance += amount;
    }
}
Console.WriteLine($"Total: {balance:f2}");