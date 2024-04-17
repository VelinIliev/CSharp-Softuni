int lines = int.Parse(Console.ReadLine());
string[] array1 = new string[lines];
string[] array2 = new string[lines];

for (int i = 0; i < lines; i++)
{
    string[] input = Console.ReadLine().Split();

    if (i % 2 == 0)
    {
        array1[i] = input[0];
        array2[i] = input[1];
    }
    else
    {
        array2[i] = input[0];
        array1[i] = input[1];
    }
}

Console.WriteLine(string.Join(" ", array1));
Console.WriteLine(string.Join(" ", array2));