double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string operatorC = Console.ReadLine();

double result;

if (operatorC == "+")
{ 
    result = num1 + num2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{num1} {operatorC} {num2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{num1} {operatorC} {num2} = {result} - odd");
    }
    
}
else if (operatorC == "-")
{
    result = num1 - num2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{num1} {operatorC} {num2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{num1} {operatorC} {num2} = {result} - odd");
    }
}
else if (operatorC == "*")
{
    result = num1 * num2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{num1} {operatorC} {num2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{num1} {operatorC} {num2} = {result} - odd");
    }
} else if (operatorC == "/")
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        result = num1 / num2;
        Console.WriteLine($"{num1} {operatorC} {num2} = {result:f2}");
    }
} else if (operatorC == "%")
{   
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        result = num1 % num2;
        Console.WriteLine($"{num1} {operatorC} {num2} = {result}");
    }
    
}
