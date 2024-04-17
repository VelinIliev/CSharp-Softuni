string pass = Console.ReadLine();

string ValidatePassword(string pass)
{
    string message = "";
    bool isPasswordValid = true;
    
    if (pass.Length < 6 || pass.Length > 10)
    {
        message += "Password must be between 6 and 10 characters#";
        isPasswordValid = false;
    }

    int countNumbers = 0;
    
    foreach (var currChar in pass)
    {
        if (Char.IsDigit(currChar))
        {
            countNumbers += 1;
        } else if (Char.IsLetter(currChar))
        {
        }
        else
        {
            message += "Password must consist only of letters and digits#";
            isPasswordValid = false;
            break;
        }
    }

    if (countNumbers < 2)
    {
        message += "Password must have at least 2 digits";
        isPasswordValid = false;
    }

    if (isPasswordValid)
    {
        message = "Password is valid";
    }
    
    return $"{string.Join("\n", message.Split("#"))}";
}

Console.WriteLine(ValidatePassword(pass));