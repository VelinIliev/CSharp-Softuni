int n = int.Parse(Console.ReadLine());
int counter = 0;
int start = 1;
int sum = 0;

while (counter < n)
{
    Console.WriteLine(start);
    counter++;
    sum += start;
    start += 2;
}

Console.WriteLine($"Sum: {sum}");