int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number ; i++)
{
    string strNumber = i.ToString();
    
    int sum = 0;
    
    for (int j = 0; j < strNumber.Length; j++)
    {
        sum += int.Parse(strNumber[j].ToString());
    }
    
    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}