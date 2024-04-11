int numbers = int.Parse(Console.ReadLine());

int maxNumber = -1000000;
int minNumber = 10000000;


for (int i = 0; i < numbers; i++)
{
    int newInput = int.Parse(Console.ReadLine());
    if (newInput > maxNumber)
    {
        maxNumber = newInput;
    }

    if (newInput < minNumber)
    {
        minNumber = newInput;
    }
}
Console.WriteLine($"Max number: {maxNumber}");
Console.WriteLine($"Min number: {minNumber}");