int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

int examTime = examHour * 60 + examMinute;
int arrivalTime = arrivalHour * 60 + arrivalMinute;

int diffrence = 0;

if (arrivalTime > examTime)
{
    Console.WriteLine("Late");
    diffrence = arrivalTime - examTime;
}
else if (arrivalTime == examTime || (examTime - arrivalTime) <= 30)
{
    Console.WriteLine("On time");
    diffrence = arrivalTime - examTime;
}
else
{
    Console.WriteLine("Early");
    diffrence = arrivalTime - examTime;
}

string condition;

if (diffrence > 0)
{
    condition = "after";
}
else
{
    condition = "before";
}

int hours;
int minutes;
string timeD = "";

if (Math.Abs(diffrence) > 59)
{
    hours = Math.Abs(diffrence) / 60;
    minutes = Math.Abs(diffrence) % 60;
    if (minutes < 10)
    { 
        timeD = $"{hours}:0{minutes} hours";
    }
    else
    {
        timeD = $"{hours}:{minutes} hours";
    }
    Console.WriteLine($"{timeD} {condition} the start");
}
else if (diffrence == 0)
{
    
}
else
{
    minutes = diffrence;
    timeD = $"{Math.Abs(minutes)} minutes";
    Console.WriteLine($"{timeD} {condition} the start");
}