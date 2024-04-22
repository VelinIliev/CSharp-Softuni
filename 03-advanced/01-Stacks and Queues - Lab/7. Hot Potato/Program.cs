List<string> input = Console.ReadLine().Split().ToList();
int number = int.Parse(Console.ReadLine());

Queue<string> kids = new Queue<string>(input);

int counter = 1;

while (kids.Count > 1)
{
    string currentKid = kids.Dequeue();
    if (counter == number)
    {
        
        Console.WriteLine($"Removed {currentKid}");
        counter = 0;
    }
    else
    {
        kids.Enqueue(currentKid);
    }
    counter += 1;
}
Console.WriteLine($"Last is {string.Join("", kids)}");