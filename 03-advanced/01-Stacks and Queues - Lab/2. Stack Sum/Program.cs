List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

var stack = new Stack<int>(numbers);

while (true)
{
    string[] input = Console.ReadLine().ToLower().Split();

    if (input[0] == "end")
    {
        break;
    }

    string command = input[0];

    if (command == "add")
    {
        int firstNumber = int.Parse(input[1]);
        int secondNumber = int.Parse(input[2]);
        
        stack.Push(firstNumber);
        stack.Push(secondNumber);
    } else if (command == "remove")
    {
        int count = int.Parse(input[1]);
        if (stack.Count >= count)
        {
            while (stack.Count > 0 && count != 0)
            {
                stack.Pop();
                count--;
            }
        }
    }
}

Console.WriteLine($"Sum: {stack.Sum()}");