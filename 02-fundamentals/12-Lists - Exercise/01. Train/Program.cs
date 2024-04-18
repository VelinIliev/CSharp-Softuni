List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int capacity = int.Parse(Console.ReadLine());

while (true)
{
    string input = Console.ReadLine();

    if (input == "end")
    {
        break;
    }

    string[] conditions = input.Split().ToArray();

    if (conditions[0] == "Add")
    {
        int passengers = int.Parse(conditions[1]);
        wagons.Add(passengers);
    }
    else
    {
        int passengers = int.Parse(conditions[0]);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passengers <= capacity)
            {
                wagons[i] += passengers;
                break;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", wagons));