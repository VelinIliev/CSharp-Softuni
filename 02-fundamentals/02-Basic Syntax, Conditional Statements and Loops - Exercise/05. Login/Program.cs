string user = Console.ReadLine();

char[] charArray = user.ToCharArray();
Array.Reverse(charArray);
string pass = new string(charArray);
int counter = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == pass)
    {
        Console.WriteLine($"User {user} logged in.");
        break;
    }

    counter++;

    if (counter == 4)
    {
        Console.WriteLine($"User {user} blocked!");
        break;
    }
    Console.WriteLine("Incorrect password. Try again.");
}