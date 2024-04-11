int numberBadEvaluations = int.Parse(Console.ReadLine());
int totalScore = 0;
int numberOfProblems = 0;
string lastProblem = "";
int badEvaluations = 0;


while (true)
{
    string name = Console.ReadLine();
    if (name == "Enough")
    {
        Console.WriteLine($"Average score: {(double)totalScore / numberOfProblems:f2}");
        Console.WriteLine($"Number of problems: {numberOfProblems}");
        Console.WriteLine($"Last problem: {lastProblem}");
        break;
    }

    int score = int.Parse(Console.ReadLine());
    if (score <= 4)
    {
        badEvaluations++;
    }

    if (numberBadEvaluations == badEvaluations)
    {
        Console.WriteLine($"You need a break, {numberBadEvaluations} poor grades.");
        break;
    }

    totalScore += score;
    numberOfProblems++;
    lastProblem = name;
}