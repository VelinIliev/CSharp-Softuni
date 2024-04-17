int number = int.Parse(Console.ReadLine());

static void PrintMatrix(int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(size + " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(number);