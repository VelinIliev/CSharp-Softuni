
double age = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();

if (age >= 16)
{
    if (gender == "f")
    {
        Console.WriteLine("Ms.");
    }
    else
    {
        Console.WriteLine("Mr.");
    }
}
else
{
    if (gender == "f")
    {
        Console.WriteLine("Miss");
    }
    else
    {
        Console.WriteLine("Master");
    }
}
