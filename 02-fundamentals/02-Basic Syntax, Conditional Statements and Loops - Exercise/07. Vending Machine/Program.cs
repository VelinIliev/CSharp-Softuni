double coins = 0;
double[] numbers = {.1, .2, .5, 1, 2};
string[] products = {"Nuts", "Crisps", "Soda", "Water", "Coke"};
Dictionary<string, double> productPrice = new() { {"Nuts", 2.0}, {"Water", 0.7}, {"Crisps", 1.5}, {"Soda", 0.8}, {"Coke", 1.0}, };

while (true)
{
    string input = Console.ReadLine();
    if (input == "Start")
    {
        break;
    }

    double newCoin = double.Parse(input);

    if (Array.Exists(numbers, x => x == newCoin))
    {
        coins += newCoin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {newCoin}");
    }
}

while (true)
{
    string input = Console.ReadLine();
    if (input == "End")
    {
        break;
    }

    string product = input;

    if (!Array.Exists(products, x => x == product))
    {
        Console.WriteLine("Invalid product");
    }
    else
    {
        if (coins - productPrice[product] < 0)
        {
            Console.WriteLine("Sorry, not enough money");
        }
        else
        {
            coins -= productPrice[product];
            Console.WriteLine($"Purchased {product.ToLower()}");
        }
    }
}

Console.WriteLine($"Change: {coins:f2}");