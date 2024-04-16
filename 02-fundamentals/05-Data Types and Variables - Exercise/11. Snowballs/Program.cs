int snowBalls = int.Parse(Console.ReadLine());

double bestSnowball = double.MinValue;
string text = "";

for (int i = 0; i < snowBalls; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());
    
    double value = Math.Pow(snow / time, quality);

    if (value > bestSnowball)
    {
        bestSnowball = value;
        text = $"{snow} : {time} = {value} ({quality})";
    }
}
Console.WriteLine(text);