string input = Console.ReadLine();
int repetitions = int.Parse(Console.ReadLine());

static void PrintStringNTimes(string input, int repetitions)
{
    for (int i = 0; i < repetitions; i++)
    {
        Console.Write(input);
    }
}

PrintStringNTimes(input, repetitions);