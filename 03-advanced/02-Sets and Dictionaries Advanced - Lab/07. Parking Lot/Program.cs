var parking = new HashSet<string>();

while (true)
{
    string[] input = Console.ReadLine().Split(", ").ToArray();

    if (input[0] == "END")
    {
        break;
    }

    string direction = input[0];
    string plate = input[1];

    if (direction == "IN")
    {
        parking.Add(plate);
    } else if (direction == "OUT")
    {
        if (parking.Contains(plate))
        {
            parking.Remove(plate);
        }
    }
}

if (parking.Count > 0)
{
    foreach (var p in parking)
    {
        Console.WriteLine(p);
    } 
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}
