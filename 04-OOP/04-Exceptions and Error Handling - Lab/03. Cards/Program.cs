List<string> faces = new List<string>{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
// List<string> suits = new List<string> { "S", "H", "D", "C"};
Dictionary<string, string> suits = new Dictionary<string, string>
{
    {"S", "\u2660" }, 
    {"H", "\u2665"},
    {"D", "\u2666"},
    {"C", "\u2663"},
};

List<String> validCards = new List<string>();

string[] input = Console.ReadLine().Split(", ");

foreach (var card in input)
{
    string[] info = card.Split();
    string face = info[0];
    string suit = info[1];

    if (!faces.Contains(face) || !suits.ContainsKey(suit))
    {
        Console.WriteLine("Invalid card!");
    }
    else
    {
        validCards.Add($"[{face}{suits[suit]}]");
    }
}

Console.WriteLine(string.Join(" ", validCards));