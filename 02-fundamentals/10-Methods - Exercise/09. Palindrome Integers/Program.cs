while (true)
{
    string input = Console.ReadLine();

    if (input == "END")
    {
        break;
    }
    Console.WriteLine(IsPalindrome(input));
}

bool IsPalindrome(string input)
{
    char[] cArray = input.ToCharArray();
    Array.Reverse(cArray);
    string reversedString = new string(cArray);
    
    if (reversedString == input)
    {
        return true;
    }

    return false;

}
