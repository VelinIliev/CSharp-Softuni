double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine());
double outfitPrice = double.Parse(Console.ReadLine());

double decor = budget * .1;

if (extras > 150)
{
    outfitPrice = outfitPrice * .9;
}

double totalPrice = extras * outfitPrice + decor;

if (totalPrice > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(totalPrice - budget).ToString("0.00")} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {(budget - totalPrice).ToString("0.00")} leva left.");
}