int Npower = int.Parse(Console.ReadLine());
int Mdistance = int.Parse(Console.ReadLine());
int YexhaustionFactor  = int.Parse(Console.ReadLine());

int power = Npower;
int targets = 0;


while (power >= Mdistance)
{
    power -= Mdistance;
    targets++;
    if (Npower / 2 == power && YexhaustionFactor != 0 )
    {
        power /= YexhaustionFactor;
    }
}

Console.WriteLine(power);
Console.WriteLine(targets);