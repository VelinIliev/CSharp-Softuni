double budget = double.Parse(Console.ReadLine());
int numberGpu = int.Parse(Console.ReadLine());
int numberCpu = int.Parse(Console.ReadLine());
int numberRam = int.Parse(Console.ReadLine());

double gpuPrice = 250;
double cpuPrice = gpuPrice * numberGpu * .35;
double ramPrice = gpuPrice * numberGpu * .1;


double total = numberGpu * gpuPrice + numberCpu * cpuPrice + numberRam * ramPrice;

if (numberGpu > numberCpu)
{
    total = total * .85;
}

if (total <= budget)
{
    Console.WriteLine($"You have {(budget - total).ToString("0.00")} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {(total - budget).ToString("0.00")} leva more!");
}