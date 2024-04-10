string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

double price = 0;

if (type == "Premiere")
{
    price = 12;
} else if (type == "Normal")
{
    price = 7.5;
} else if (type == "Discount")
{
    price = 5;
}

Console.WriteLine($"{(price * rows * columns).ToString("0.00")} leva");