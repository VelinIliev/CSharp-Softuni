int n = int.Parse(Console.ReadLine());

int counter = 1;
bool isFinished = false;


for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        if (counter > n)
        {
            isFinished = true;
            break;
        }
        Console.Write($"{counter} ");
        counter++;
    }

    if (isFinished)
    {
        break;
    }
    Console.Write("\n");
}
