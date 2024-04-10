int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int newTime = hours * 60 + minutes + 15;

int newHours = newTime / 60;
int newMinutes = newTime % 60;

string result = "";

if (newHours > 23)
{
    result += "0";
}
else
{
    result += $"{newHours}";
}

if (newMinutes < 10)
{
    result += $":0{newMinutes}";
}
else
{
    result += $":{newMinutes}";
}

Console.WriteLine(result);