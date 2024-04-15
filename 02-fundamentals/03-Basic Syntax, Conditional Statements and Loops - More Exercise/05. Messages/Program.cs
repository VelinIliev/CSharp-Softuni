Dictionary<string, string> msgLetters = new()
{
    {"2", "abc"},
    {"3", "def"},
    {"4", "ghi"},
    {"5", "jkl"},
    {"6", "mno"},
    {"7", "pqrs"},
    {"8", "tuv" },
    {"9", "wxyz" },
    {"0", " " },
};

int n = int.Parse(Console.ReadLine());
string message = "";

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    message += msgLetters[input[0].ToString()][input.Length - 1];
}

Console.WriteLine(message);