double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double secondsPerMeter = double.Parse(Console.ReadLine());


double totalTime = distance * secondsPerMeter + (Math.Floor(distance / 15)) * 12.5;


if (totalTime < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime.ToString("0.00")} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {(totalTime - record).ToString("0.00")} seconds slower.");
}