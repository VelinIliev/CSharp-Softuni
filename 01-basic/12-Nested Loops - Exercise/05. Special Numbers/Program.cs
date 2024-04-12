int number = int.Parse(Console.ReadLine());

for (int i = 1111; i < 10000; i++)
{
    int isSpecialNumber = 0;

    for (int j = 0; j < i.ToString().Length; j++)
    {
        int digit = int.Parse(i.ToString()[j].ToString());
        if (digit != 0 && number % digit == 0)
        {
            isSpecialNumber += 1;
        } 
    }

    if (isSpecialNumber == 4)
    {
        Console.Write($"{i} ");
    }
}