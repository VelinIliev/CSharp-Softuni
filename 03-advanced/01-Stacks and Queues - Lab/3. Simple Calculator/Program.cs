List<string> input = Console.ReadLine().Split().ToList();

input.Reverse();
var stack = new Stack<string>(input);

while (stack.Count > 1)
{
    int firstNumber = int.Parse(stack.Pop());
    string operatorX = stack.Pop();
    int secondNumber = int.Parse(stack.Pop());

    if (operatorX == "+")
    {
        stack.Push((firstNumber + secondNumber).ToString());
    } else if (operatorX == "-")
    {
        stack.Push((firstNumber - secondNumber).ToString());
    }
}

Console.WriteLine(stack.Pop());
