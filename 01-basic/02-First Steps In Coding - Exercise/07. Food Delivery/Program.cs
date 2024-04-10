double priceChickenMenu = 10.35;
double priceFishMenu = 12.40;
double priceVeganMenu = 8.15;

int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu= int.Parse(Console.ReadLine());
int veganMenu= int.Parse(Console.ReadLine());

double price = (chickenMenu * priceChickenMenu + fishMenu * priceFishMenu + veganMenu * priceVeganMenu) * 1.2 + 2.5;

Console.WriteLine(price);