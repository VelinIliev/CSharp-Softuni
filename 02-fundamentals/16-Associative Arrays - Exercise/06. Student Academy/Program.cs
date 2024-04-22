Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

int lines = int.Parse(Console.ReadLine());

for (int i = 0; i < lines; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (grades.ContainsKey(name))
    {
        grades[name].Add(grade);
    }
    else
    {
        grades.Add(name, new List<double>());
        grades[name].Add(grade);
    }
}

foreach (var student in grades)
{
    double avg = student.Value.Sum() / student.Value.Count;

    if (avg >= 4.5)
    {
        Console.WriteLine($"{student.Key} -> {avg:f2}");
    }
}