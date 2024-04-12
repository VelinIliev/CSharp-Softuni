int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int currentTime = hours * 60 + minutes + 30;

int newHours = currentTime / 60;
int newMinutes = currentTime % 60;

if (newHours == 24)
{
    newHours = 0;
} 

if (newMinutes < 10)
{
    Console.WriteLine($"{newHours}:0{newMinutes}");
}
else
{
    Console.WriteLine($"{newHours}:{newMinutes}");
}