string name = Console.ReadLine();
int grade = 1;
int excluded = 0;
double evaluationSum = 0;

while (true)
{
    double evaluation = double.Parse(Console.ReadLine());
    if (evaluation < 4)
    {
        excluded += 1;
        grade--;
    }
    grade += 1;
    evaluationSum += evaluation;

    if (excluded == 2)
    {
        Console.WriteLine($"{name} has been excluded at {grade} grade");
        break;
    }

    if (grade == 13)
    {
        Console.WriteLine($"{name} graduated. Average grade: {evaluationSum/12:f2}");
        break;
    }
}
