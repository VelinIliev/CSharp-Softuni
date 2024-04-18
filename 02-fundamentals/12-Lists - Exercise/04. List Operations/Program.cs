List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }

    string[] conditions = input.Split();
    string action = conditions[0];

    if (action == "Add")
    {
        int number = int.Parse(conditions[1]);
        numbers.Add(number);
    } else if (action == "Insert")
    {
        int number = int.Parse(conditions[1]);
        int index = int.Parse(conditions[2]);
        if (index < 0 || index > numbers.Count)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.Insert(index, number);
        }
        ;
    } else if (action == "Remove")
    {
        int index = int.Parse(conditions[1]);
        if (index < 0 || index > numbers.Count)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.RemoveAt(index);
        }
    } else if (action == "Shift")
    {
        string direction = conditions[1];
        int count = int.Parse(conditions[2]);
        if (direction == "left")
        {
            for (int i = 0; i < count;  i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        } else if (direction == "right")
        {
            for (int i = 0; i < count;  i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}

Console.WriteLine(string.Join(" ", numbers));