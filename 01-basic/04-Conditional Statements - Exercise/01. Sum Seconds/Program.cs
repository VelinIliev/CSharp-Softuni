int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int seconds = ((firstTime + secondTime + thirdTime) % 60);
int minutes = ((firstTime + secondTime + thirdTime) / 60);

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}
