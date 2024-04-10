double pricePens = 5.80;
double priceMarkers = 7.20;
double priceDetergent = 1.2;


int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int detergent = int.Parse(Console.ReadLine());

int discount = int.Parse(Console.ReadLine());

double price = ( pens * pricePens + markers * priceMarkers + detergent * priceDetergent ) * (100 - discount) / 100;

Console.WriteLine(price);