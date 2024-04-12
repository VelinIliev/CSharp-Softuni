int age = int.Parse(Console.ReadLine());

switch (age)
{
    case <= 2: Console.WriteLine("baby"); break;
    case <= 13: Console.WriteLine("child"); break;
    case <= 19: Console.WriteLine("teenager"); break;
    case <= 65: Console.WriteLine("adult"); break;
    default: Console.WriteLine("elder"); break;
}