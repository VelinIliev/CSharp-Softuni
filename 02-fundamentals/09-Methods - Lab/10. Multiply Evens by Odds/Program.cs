string input = Console.ReadLine();

int GetMultipleOfEvenAndOdds(string input)
{
    int evenSum = 0;
    int oddSum = 0;

    foreach (var x in input)
    {
        if (Char.IsDigit(x))
        {
            int number = int.Parse(x.ToString());
            if (number % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }
    }
    return evenSum * oddSum;
} 

Console.WriteLine(GetMultipleOfEvenAndOdds(input));