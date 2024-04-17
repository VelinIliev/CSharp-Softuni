int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());


int CalculateSum(int num1, int num2)
{
    return num1 + num2;
}

int CalculateDiff(int num1, int num2)
{
    return num1 - num2;
}

Console.WriteLine(CalculateDiff(CalculateSum(num1, num2), num3));