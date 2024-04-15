Dictionary<string, double> games = new()
{
    {"OutFall 4", 39.99},
    {"CS: OG", 15.99},
    {"Zplinter Zell", 19.99},
    {"Honored 2", 59.99},
    {"RoverWatch", 29.99},
    {"RoverWatch Origins Edition", 39.99},
};

double total = double.Parse(Console.ReadLine());
double moneySpent = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "Game Time")
    {   
        Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${total - moneySpent:f2}");
        break;
    }

    if (games.ContainsKey(input))
    {
        if (total - moneySpent - games[input] >= 0)
        {
            Console.WriteLine($"Bought {input}");
            moneySpent += games[input];
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else
    {
        Console.WriteLine("Not Found");
    }

    if (total - moneySpent == 0)
    {
        Console.WriteLine("Out of money!");
        break;
    }
}