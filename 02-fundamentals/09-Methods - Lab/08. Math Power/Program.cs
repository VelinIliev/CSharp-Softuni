double number = double.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

double Power(double number, int power)
{
    double result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}

Console.WriteLine(Power(number, power));