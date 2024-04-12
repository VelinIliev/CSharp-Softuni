int juryMembers = int.Parse(Console.ReadLine());

int counter = 0;
double totalGradesSum = 0;

while (true)
{
    string input = Console.ReadLine();
    
    if (input == "Finish")
    {
        break;
    }
    double gradesSum = 0;
    
    for (int n = 0; n < juryMembers; n++)
    {
        double grade = double.Parse(Console.ReadLine());
        gradesSum += grade;
    }
    Console.WriteLine($"{input} - {gradesSum / juryMembers:f2}.");
    counter++;
    totalGradesSum += gradesSum / juryMembers;
}
Console.WriteLine($"Student's final assessment is {totalGradesSum / counter:f2}.");