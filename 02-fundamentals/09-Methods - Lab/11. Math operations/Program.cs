double num1 = double.Parse(Console.ReadLine());
string action = Console.ReadLine();
double num2= double.Parse(Console.ReadLine());

double Calculate(string action, double num1, double num2)
{
    double result = 0;
    switch (action)
    {
        case "/": result = num1 / num2; break;
        case "*": result = num1 * num2; break;
        case "+": result = num1 + num2; break;
        case "-": result = num1 - num2; break;
    }
    return result;
}

Console.WriteLine(Calculate(action, num1, num2));