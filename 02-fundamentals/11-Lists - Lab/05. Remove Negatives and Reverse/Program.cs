List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

foreach (int number in numbers)
{
    if (number >= 0) 
    {
        result.Add(number);
    }
}

result.Reverse();
if (result.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", result));
}