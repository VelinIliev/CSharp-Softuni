int numbers = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < numbers * 2; i++)
{
    int newNUmber = int.Parse(Console.ReadLine());
    if (i < numbers)
    {
        leftSum += newNUmber;
    }
    else
    {
        rightSum += newNUmber;
    }
}
if (leftSum == rightSum) 
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
}