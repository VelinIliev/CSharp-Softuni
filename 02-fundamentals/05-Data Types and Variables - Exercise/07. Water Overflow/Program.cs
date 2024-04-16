int capacity = 255;
int filled = 0;

int lines = int.Parse(Console.ReadLine());

for (int i = 0; i < lines; i++)
{
    int quantity = int.Parse(Console.ReadLine());
    if (filled + quantity > capacity)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        filled += quantity;
    }
}
Console.WriteLine(filled);