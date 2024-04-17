int lines = int.Parse(Console.ReadLine());

static void DrawTop(int lines) {
    for (int i = 1; i <= lines; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}

static void DrawBottom(int lines)
{
    for (int i = lines; i > 0; i--)
    {
        for (int j = 1; j < i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}

DrawTop(lines);
DrawBottom(lines);