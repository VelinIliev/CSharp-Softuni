Dictionary<int, double> accounts = new Dictionary<int, double>();

string[] input = Console.ReadLine().Split(",");

foreach (var acc in input)
{
    string[] info = acc.Split("-");
    int account = int.Parse(info[0]);
    double amount = double.Parse(info[1]);
    accounts.Add(account, amount);
}

while (true)
{
    string[] newInput = Console.ReadLine().Split();
    string command = newInput[0];
    
    if (command == "End")
    {
        break;
    }
    
    int account = int.Parse(newInput[1]);
    double amount = double.Parse(newInput[2]);

    if (!accounts.ContainsKey(account))
    {
        Console.WriteLine("Invalid account!");
        Console.WriteLine("Enter another command");
        continue;
    } 
    
    if (command == "Deposit")
    {
        accounts[account] += amount;
        Console.WriteLine($"Account {account} has new balance: {accounts[account]:f2}");
    } else if (command == "Withdraw")
    {
        if (accounts[account] - amount < 0)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            accounts[account] -= amount;
            Console.WriteLine($"Account {account} has new balance: {accounts[account]:f2}");
        }
    }
    else
    {
        Console.WriteLine("Invalid command!");
    }
    Console.WriteLine("Enter another command");
}