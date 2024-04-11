int numbers = int.Parse(Console.ReadLine());

int totalSum = 0;

for (int i = 0; i < numbers; i++)
{
    int newInput = int.Parse(Console.ReadLine());
    totalSum += newInput;
}

Console.WriteLine(totalSum);