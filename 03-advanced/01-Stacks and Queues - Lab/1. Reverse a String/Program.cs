string input = Console.ReadLine();

var stack = new Stack<char>();

foreach (var c in input)
{
    stack.Push(c);
}

while (stack.Any())
{
    Console.Write(stack.Pop());
}