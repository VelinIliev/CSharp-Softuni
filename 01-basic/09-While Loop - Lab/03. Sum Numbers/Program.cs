int firstNumber = int.Parse(Console.ReadLine());
int currentSum = 0;

while (true)
{
    int newNumber = int.Parse(Console.ReadLine());
    currentSum += newNumber;
    if (currentSum >= firstNumber)
    {
        Console.WriteLine(currentSum);
        break;
    }
}