int end = int.Parse(Console.ReadLine());
List<int> dividers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();

List<int> numbers = new List<int>();

for (int i = 1; i <= end; i++)
{
    numbers.Add(i);
}

List<int> divisibleNumbers = new List<int>();

foreach (var number in numbers)
{
    bool isDivisble = true;
    foreach (var divider in dividers)
    {
        if (number % divider != 0)
        {
            isDivisble = false;
        }
    }

    if (isDivisble)
    {
        divisibleNumbers.Add(number);
    }
}

Console.WriteLine(string.Join(" ", divisibleNumbers));