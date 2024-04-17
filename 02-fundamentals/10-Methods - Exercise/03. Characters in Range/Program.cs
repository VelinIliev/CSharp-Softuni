char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());

if ((int)start > (int)end)
{
    char tmp = start;
    start = end;
    end = tmp;
}

for (int i = (int)start + 1; i < (int)end ; i++)
{
    Console.Write((char)i + " ");
}