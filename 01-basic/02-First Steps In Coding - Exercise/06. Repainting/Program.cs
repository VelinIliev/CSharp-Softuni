double priceNylon = 1.5;
double pricePaint = 14.5;
double priceТhinner = 5;

int nylonNeeded = int.Parse(Console.ReadLine()) + 2;
double paintNeeded = int.Parse(Console.ReadLine()) * 1.1;
int thinnerNeeded = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double materialsPrice = nylonNeeded * priceNylon + paintNeeded * pricePaint + thinnerNeeded * priceТhinner + .4;
double mastersPrice = (materialsPrice * .3) * hours;

Console.WriteLine(materialsPrice + mastersPrice);