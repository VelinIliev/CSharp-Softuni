double numbers = double.Parse(Console.ReadLine());

double p1 = 0;
double p2 = 0;
double p3 = 0;
double p4 = 0;
double p5 = 0;

for (int i = 0; i < numbers; i++)
{
    double newNumber = double.Parse(Console.ReadLine());
    if (newNumber < 200)
    {
        p1++;
    } else if (newNumber < 400)
    {
        p2++;
    } else if (newNumber < 600)
    {
        p3++;
    } else if (newNumber < 800)
    {
        p4++;
    }
    else
    {
        p5++;
    }
}

if (p1 != 0)
{   
    Console.WriteLine($"{((p1 / numbers) * 100):f2}%");
}
else
{
    Console.WriteLine($"0.00%");
}
if (p2 != 0)
{
    Console.WriteLine($"{((p2 / numbers) * 100):f2}%");
}
else
{
    Console.WriteLine($"0.00%");
}
if (p3 != 0)
{
    Console.WriteLine($"{((p3 / numbers) * 100):f2}%");
}
else
{
    Console.WriteLine($"0.00%");
}
if (p4 != 0)
{
    Console.WriteLine($"{((p4 / numbers) * 100):f2}%");
}
else
{
    Console.WriteLine($"0.00%");
}
if (p5 != 0)
{
    Console.WriteLine($"{((p5 / numbers) * 100):f2}%");
}
else
{
    Console.WriteLine($"0.00%");
}