List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string input = Console.ReadLine();
    
    if (input == "end")
    {
        break;
    }

    string[] conditions = input.Split();
    string action = conditions[0];

    if (action == "Delete")
    {
        int element = int.Parse(conditions[1]);
        
        while (numbers.Contains(element))
        {
            numbers.Remove(element);
        }
    } else if (action == "Insert")
    {
        int element = int.Parse(conditions[1]);
        int index = int.Parse(conditions[2]);
        numbers.Insert(index, element);
    }
}
Console.WriteLine(string.Join(" ", numbers));