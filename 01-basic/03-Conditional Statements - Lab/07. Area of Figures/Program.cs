string type = Console.ReadLine();

double result;

if (type == "square")
{
    double side = double.Parse(Console.ReadLine());
    result = (side * side);
} 
else if (type == "rectangle")
{
    double side1 = double.Parse(Console.ReadLine());
    double side2 = double.Parse(Console.ReadLine());
    result = (side1 * side2);
} 
else if (type == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    result = Math.PI * radius * radius;
} 
else if (type == "triangle")
{
    double side = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    result = side * height / 2;
}
else
{
    result = 0;
}

Console.WriteLine("{0:F3}", result);