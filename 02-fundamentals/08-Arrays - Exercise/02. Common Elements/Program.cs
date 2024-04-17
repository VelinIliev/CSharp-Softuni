string[] array1 = Console.ReadLine().Split();
string[] array2 = Console.ReadLine().Split();

string common = "";

for (int i = 0; i < array2.Length; i++)
{
    if (array1.Contains(array2[i]))
    {
        common += array2[i] + " ";
    }
}
Console.WriteLine(common);