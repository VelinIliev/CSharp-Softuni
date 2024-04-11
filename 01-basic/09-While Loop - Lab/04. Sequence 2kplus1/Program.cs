int inputNumber = int.Parse(Console.ReadLine());
int currentNumber = 1;

while (currentNumber <= inputNumber)
{
    Console.WriteLine(currentNumber);
    currentNumber = currentNumber * 2 + 1;
}