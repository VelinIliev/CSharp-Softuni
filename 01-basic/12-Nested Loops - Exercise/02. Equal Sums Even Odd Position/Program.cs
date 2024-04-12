int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());


for (int number = firstNumber; number <= secondNumber; number++)
{
    string strNumber = number.ToString();
    int evenSum = 0;
    int oddSum = 0;
    for (int i = 0; i < strNumber.Length; i++)
    {
        if (i % 2 == 0)
        {
            evenSum += int.Parse(strNumber[i].ToString());
        }
        else
        {
            oddSum += int.Parse(strNumber[i].ToString());
        }
    }

    if (evenSum == oddSum)
    {
        Console.Write($"{strNumber} ");
    }
}