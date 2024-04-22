Dictionary<string, string> parking = new Dictionary<string, string>();

int lines = int.Parse(Console.ReadLine());

for (int i = 0; i < lines; i++)
{
    string[] info = Console.ReadLine().Split().ToArray();
    string action = info[0];
    string username = info[1];
    

    if (action == "register")
    {
        string plate = info[2];
        if (parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {plate}");
        }
        else
        {
            parking.Add(username, plate);
            Console.WriteLine($" {username} registered {plate} successfully");
        }
    } else if (action == "unregister")
    {
        if (!parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            parking.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}

foreach (var car in parking)
{
    Console.WriteLine($"{car.Key} => {car.Value}");
}
