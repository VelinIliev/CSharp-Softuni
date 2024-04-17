double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double CalculateArea(double width, double height)
{
    return width * height;
}

Console.WriteLine(CalculateArea(width, height));