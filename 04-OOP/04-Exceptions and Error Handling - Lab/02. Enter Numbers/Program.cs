List<int> numbers = new List<int>();

int start = 1;
int end = 100;

while (numbers.Count != 10)
{
    try
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= start || number > end)
        {
            throw new ArgumentException($"Your number is not in range {start} - 100!");
        }

        start = number;
        numbers.Add(number);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
    

Console.WriteLine($"{string.Join(", ", numbers)}");