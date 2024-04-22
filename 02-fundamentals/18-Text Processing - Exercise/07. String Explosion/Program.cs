string input = Console.ReadLine();
int bomb = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        bomb += int.Parse((input[i + 1].ToString()));
        
    }
    else
    {
        if (bomb > 0)
        {
            input = input.Remove(i, 1);
            bomb--;
            i--;
        }
    }
}
Console.WriteLine(input);