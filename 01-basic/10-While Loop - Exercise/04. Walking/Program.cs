int goal = 10000;
int steps = 0;

while (true)
{
    string input = Console.ReadLine();
    
    if (input == "Going home")
    {
        steps += int.Parse(Console.ReadLine());
        break;
    }

    steps += int.Parse(input);

    if (steps >= goal)
    {
        break;
    }
}

if (steps >= goal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{steps - goal} steps over the goal!");
}
else
{
    Console.WriteLine($"{goal - steps} more steps to reach goal.");
}