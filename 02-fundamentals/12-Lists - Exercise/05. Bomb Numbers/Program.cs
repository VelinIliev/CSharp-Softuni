List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int bomb = input[0];
int power = input[1];

while (numbers.Contains(bomb))
{
    int bombIndex = numbers.IndexOf(bomb);
    int startIndex = bombIndex - power;
    int endIndex = bombIndex + power;
    
    if (startIndex < 0)
    {
        startIndex = 0;
    }

    if (endIndex > numbers.Count)
    {
        endIndex = numbers.Count - 1;
    }

    int count = endIndex + 1 - startIndex; 
    
    numbers.RemoveRange(startIndex, count);
}

Console.WriteLine(numbers.Sum());
