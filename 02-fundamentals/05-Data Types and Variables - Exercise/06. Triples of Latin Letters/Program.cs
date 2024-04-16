int input = int.Parse(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    for (int j = 0; j < input; j++)
    {
        for (int k = 0; k < input; k++)
        {
            char x = (char)('a' + i);
            char y = (char)('a' + j);
            char z = (char)('a' + k);
            Console.WriteLine($"{x}{y}{z}");
        }
    }
}