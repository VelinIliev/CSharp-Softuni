﻿
string input = Console.ReadLine();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        stack.Push(i);
    }

    if (input[i] == ')')
    {
        int start = stack.Pop();
        int end = i;
        string subString = input.Substring(start, end - start + 1);
        Console.WriteLine(subString);
    }   
}

