int number = int.Parse(Console.ReadLine());

for (int ch = 1; ch <= number; ch++)
{
    int currentNumber = ch;
    int sum = 0;
    
    while (currentNumber > 0)
    {
        sum += currentNumber % 10;
        currentNumber = currentNumber / 10;
    }
    
    bool isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", ch, isSpecialNumber);
}