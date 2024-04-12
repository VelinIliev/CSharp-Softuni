int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int counter = 0;
bool found = false;

for (int x1 = num1; x1 <= num2; x1++)
{
    for (int x2 = num1; x2 <= num2; x2++)
    {
        counter++;
        
        if (x1 + x2 == magicNumber)
        {
            Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {magicNumber})");
            found = true;
        }

        if (found)
        {
            break;
        }
    }
    if (found)
    {
        break;
    }
}

if (found == false)
{
    Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
}