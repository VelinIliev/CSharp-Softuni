int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

double Factorial(int number)
{
    double result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
}

Console.WriteLine($"{Factorial(num1) / Factorial(num2):f2}");

