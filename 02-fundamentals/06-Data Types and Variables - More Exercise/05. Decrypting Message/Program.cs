int key = int.Parse(Console.ReadLine());
int lines = int.Parse(Console.ReadLine());

string message = "";

for (int i = 0; i < lines; i++)
{
    char x = char.Parse(Console.ReadLine());
    message += (char)((int)x + key);
}

Console.WriteLine(message);