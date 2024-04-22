string[] usernames = Console.ReadLine().Split(", ").ToArray();

List<string> validUsernames = new List<string>();

for (int i = 0; i < usernames.Length; i++)
{
    string username = usernames[i];

    bool isValid = true;

    if (username.Length < 3 || username.Length > 16)
    {
        isValid = false;
    }

    for (int j = 0; j < username.Length; j++)
    {
        foreach (var c in username)
        {
            if (Char.IsLetter(c) || Char.IsDigit(c) || c == '_' || c == '-')
            {
                
            }
            else
            {
                isValid = false;
            }
        }
    }
    if (isValid)
    {
        validUsernames.Add(username);
    }
}


Console.WriteLine(string.Join("\n", validUsernames));