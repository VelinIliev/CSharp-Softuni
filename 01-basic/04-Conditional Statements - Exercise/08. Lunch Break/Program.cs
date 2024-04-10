string movie = Console.ReadLine();
double movieDuration = int.Parse(Console.ReadLine());
double restDuration = double.Parse(Console.ReadLine());

double lunchTime = restDuration / 8;
double restTime = restDuration / 4;

double totalTime = movieDuration + lunchTime + restTime;

if (totalTime <= restDuration)
{
    Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(restDuration - totalTime)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(totalTime - restDuration)} more minutes.");
}