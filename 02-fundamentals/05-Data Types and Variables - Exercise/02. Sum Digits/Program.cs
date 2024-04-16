string number = Console.ReadLine();
int sum = 0;

foreach (var num in number)
{
    sum += int.Parse(num.ToString());
}

Console.WriteLine(sum);