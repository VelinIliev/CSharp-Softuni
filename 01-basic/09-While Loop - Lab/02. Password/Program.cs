string name = Console.ReadLine();
string pass = Console.ReadLine();

while (true)
{
    string input = Console.ReadLine();
    if (pass == input)
    {
        Console.WriteLine($"Welcome {name}!");
        break;
    }
}