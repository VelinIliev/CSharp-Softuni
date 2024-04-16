int lines = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < lines; i++)
{
    sum += (int)char.Parse(Console.ReadLine());
}
Console.WriteLine($"The sum equals: {sum}");