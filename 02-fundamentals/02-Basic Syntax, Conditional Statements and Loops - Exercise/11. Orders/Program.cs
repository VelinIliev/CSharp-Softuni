int n = int.Parse(Console.ReadLine());

double grandTotal = 0;

for (int i = 0; i < n; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int quantity = int.Parse(Console.ReadLine());

    double total = pricePerCapsule * days * quantity;
    
    Console.WriteLine($"The price for the coffee is: ${total:f2}");

    grandTotal += total;
}

Console.WriteLine($"Total: ${grandTotal:f2}");
