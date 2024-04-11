string input = Console.ReadLine();

int totalSum = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'a')
    {
        totalSum += 1;
    }
    else if (input[i] == 'e')
    {
        totalSum += 2;
    }
    else if (input[i] == 'i')
    {
        totalSum += 3;
    }    
    else if (input[i] == 'o')
    {
        totalSum += 4;
    }    
    else if (input[i] == 'u')
    {
        totalSum += 5;
    }
}
Console.WriteLine(totalSum);