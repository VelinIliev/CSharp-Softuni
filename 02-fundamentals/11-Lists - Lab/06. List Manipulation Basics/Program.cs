List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string input = Console.ReadLine();
    if (input == "end")
    {
        break;
    }
    string[] commands = input.Split().ToArray();
    string command = commands[0];
    int number = int.Parse(commands[1]);

    if (command == "Add")
    {
        numbers.Add(number);
    } else if (command == "Remove")
    {
        numbers.Remove(number);
    } else if (command == "RemoveAt")
    {
        numbers.RemoveAt(number);
    } else if (command == "Insert")
    {
        int index = int.Parse(commands[2]);
        numbers.Insert(index, number);
    }
}

Console.WriteLine(string.Join(" ", numbers));