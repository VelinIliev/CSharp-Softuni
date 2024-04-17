int number = int.Parse(Console.ReadLine());

bool CheckTopNumber(int number)
{
    bool isDevisible = false;
    bool haveOddDigit = false;
    
    string strNumber = number.ToString();
    int sum = 0;

    foreach (var x in strNumber)
    {
        sum += int.Parse(x.ToString());
        if (x % 2 != 0)
        {
            haveOddDigit = true;
        }
    }

    if (sum % 8 == 0)
    {
        isDevisible = true;
    }
    
    return (isDevisible && haveOddDigit);
}

for (int i = 1; i <= number; i++)
{
    if (CheckTopNumber(i))
    {
        Console.WriteLine(i);
    };
}