string flowerType = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());

double price = 0.00;


if (flowerType == "Roses")
{
    price = 5;
    if (quantity > 80)
    {
        price = price * 0.9;
    }
} else if (flowerType == "Dahlias")
{
    price = 3.8;
    if (quantity > 90)
    {
        price = price * 0.85;
    }
} else if (flowerType == "Tulips")
{
    price = 2.8;
    if (quantity > 80)
    {
        price = price * 0.85;
    }
} else if (flowerType == "Narcissus")
{
    price = 3;
    if (quantity < 120)
    {
        price = price * 1.15;
    }
} else if (flowerType == "Gladiolus")
{
    price = 2.5;
    if (quantity < 80)
    {
        price = price * 1.2;
    }
}

double totalPrice = price * quantity;

if (totalPrice <= budget)
{
    Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {(budget - totalPrice).ToString("0.00")} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {(totalPrice - budget).ToString("0.00")} leva more.");
}