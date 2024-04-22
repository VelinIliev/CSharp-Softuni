while (true)
{
    string input = Console.ReadLine();

    if (input == "end")
    {
        break;
    }

    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    
    Console.WriteLine($"{input} = {new string(charArray)}");
}