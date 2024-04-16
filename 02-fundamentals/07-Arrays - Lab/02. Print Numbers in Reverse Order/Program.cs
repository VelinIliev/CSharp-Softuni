int lines = int.Parse(Console.ReadLine());

int[] numbers = new int[lines];

for (int i = 0; i < lines; i++)
{
    int newNumber = int.Parse(Console.ReadLine());
    numbers[i] = newNumber;
}

Array.Reverse(numbers);

Console.WriteLine(string.Join(" ", numbers));