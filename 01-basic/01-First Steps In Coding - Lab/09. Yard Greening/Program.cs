double sqm = double.Parse(Console.ReadLine());

double price = sqm * 7.61;
double discount = price * 0.18;

Console.WriteLine($"The final price is: {price - discount} lv.");
Console.WriteLine($"The discount is: {discount} lv.");