List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();


while (player1.Count != 0 && player2.Count != 0)
{
    int player1Hand = player1[0];
    int player2Hand = player2[0];
    player1.RemoveAt(0);
    player2.RemoveAt(0);
    

    if (player1Hand > player2Hand)
    {
        player1.Add(player1Hand);
        player1.Add(player2Hand);
    } else if (player1Hand < player2Hand)
    {
        player2.Add(player2Hand);
        player2.Add(player1Hand);
    } 
}

if (player1.Count > 0)
{
    Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
}
else
{
    Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");
}
