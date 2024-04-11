int numbers = int.Parse(Console.ReadLine());

int maxNumber = 0;
int totalSum = 0;

for (int i = 0; i < numbers; i++)
{
    int newNumber = int.Parse(Console.ReadLine());
    totalSum += newNumber;
    if (maxNumber < newNumber)
    {
        maxNumber = newNumber;
    }
}

if (totalSum - maxNumber == maxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxNumber}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(maxNumber - (totalSum - maxNumber))}");
}