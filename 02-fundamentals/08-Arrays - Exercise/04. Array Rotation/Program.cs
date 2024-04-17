string[] arr = Console.ReadLine().Split();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    var firstNumber = arr[0];
    Array.Copy(arr, 1, arr, 0, arr.Length- 1);
    arr[arr.Length - 1] = firstNumber;
}

Console.WriteLine(string.Join(" ", arr));