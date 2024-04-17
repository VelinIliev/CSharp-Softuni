string[] input = Console.ReadLine().Split().ToArray();

int maxSequence = 0;
string maxSymbol = "";

int sequenceCounter = 0;
string currentSymbol = "";

for (int i = 0; i < input.Length; i++)
{
    if (i == 0)
    {
        if (input[i] == input[i + 1])
        {
            sequenceCounter += 1;
            currentSymbol = input[i];
        }
    } 
    else if (input[i] == input[i - 1])
    {
        sequenceCounter += 1;
        currentSymbol = input[i];
    }
    else
    {
        sequenceCounter = 1;
    }

    if (sequenceCounter > maxSequence)
    {
        maxSequence = sequenceCounter;
        maxSymbol = currentSymbol;
    }
}

for (int i = 0; i < maxSequence; i++)
{
    Console.Write($"{maxSymbol} ");
}