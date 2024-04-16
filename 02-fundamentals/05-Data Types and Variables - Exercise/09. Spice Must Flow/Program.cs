int extracted = int.Parse(Console.ReadLine());

int days = 0;
int total = 0;

while (extracted >= 100)
{
    total += Math.Max(extracted - 26, 0);
    extracted -= 10;
    days++;
}

Console.WriteLine(days);
Console.WriteLine(Math.Max(total - 26, 0));