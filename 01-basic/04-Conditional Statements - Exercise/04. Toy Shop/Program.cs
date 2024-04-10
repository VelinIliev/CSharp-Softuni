double puzzlePrice = 2.6;
double dollPrice = 3;
double bearPrice = 4.1;
double minionPrice = 8.2;
double truckPrice = 2;


double tripPrice = double.Parse(Console.ReadLine());
int numberPuzzles = int.Parse(Console.ReadLine());
int numberDolls = int.Parse(Console.ReadLine());
int numberBears = int.Parse(Console.ReadLine());
int numberMinions = int.Parse(Console.ReadLine());
int numberTrucks = int.Parse(Console.ReadLine());

int items = numberPuzzles + numberDolls + numberBears + numberMinions + numberTrucks;
double total = numberPuzzles * puzzlePrice + numberDolls * dollPrice + numberBears * bearPrice + numberMinions * 
    minionPrice + numberTrucks * truckPrice;

if (items >= 50)
{
    total = total * .75;
}

total = total * .9;

if (total - tripPrice >= 0)
{
    double moneyLeft = total - tripPrice;
    Console.WriteLine($"Yes! {moneyLeft.ToString("0.00")} lv left.");
}
else
{
    double moneyMissing = tripPrice - total;
    Console.WriteLine($"Not enough money! {moneyMissing.ToString("0.00")} lv needed.");
}