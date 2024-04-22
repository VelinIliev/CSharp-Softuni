List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

numbers.Sort();
numbers.Reverse();

if (numbers.Count > 2)
{
    var first3 = numbers.Take(3);
    Console.WriteLine(string.Join(" ", first3));
}
else
{
    Console.WriteLine(string.Join(" ", numbers));
}

;