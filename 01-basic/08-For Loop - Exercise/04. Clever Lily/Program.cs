int lilysAge = int.Parse(Console.ReadLine());
double washingmachinePrice = double.Parse(Console.ReadLine());
double toyPrice = double.Parse(Console.ReadLine());

double total = 0;
double totalToys = 0;
double lastAmont = 10;

for (int i = 1; i <= lilysAge; i++)
{
    if (i % 2 == 0)
    {
        total += lastAmont - 1;
        lastAmont += 10;
    }
    else
    {
        totalToys++;
    }
}

total += totalToys * toyPrice;

if (total >= washingmachinePrice)
{
    Console.WriteLine($"Yes! {total - washingmachinePrice:f2}");
}
else
{
    Console.WriteLine($"No! {washingmachinePrice - total:f2}");
}