string action = Console.ReadLine();
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

double Calculate(string action, double num1, double num2)
{
    double result = 0;
    switch (action)
    {
        case "add": result = Add(num1, num2); break;
        case "multiply": result = Multiply(num1, num2); break;
        case "subtract": result = Subtract(num1, num2); break;
        case "divide": result = Divide(num1, num2); break;
    }

    return result;
}

double Add(double num1, double num2)
{
    return num1 + num2;
}
double Multiply(double num1, double num2)
{
    return num1 * num2;
}
double Subtract(double num1, double num2)
{
    return num1 - num2;
}
double Divide(double num1, double num2)
{
    return num1 / num2;
}

Console.WriteLine(Calculate(action, num1, num2));