int numbers = int.Parse(Console.ReadLine());

int oddSum = 0;
int evenSum = 0;

for (int i = 0; i < numbers; i++)
{
    int newNumber = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        oddSum += newNumber;
    }
    else
    {
        evenSum += newNumber;
    }
}

if (evenSum == oddSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {oddSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
}