int lines = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

for (int i = 0; i < lines; i++)
{
    string[] input = Console.ReadLine().Split();

    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (students.ContainsKey(name))
    {
        students[name].Add(grade);
    }
    else
    {
        students.Add(name, new List<decimal>());
        students[name].Add(grade);
    }
}

foreach (var s in students)
{
    List<string> grades = new List<string>();
    foreach (var g in s.Value)
    {
        grades.Add($"{g:f2}");
    }
    Console.WriteLine($"{s.Key} -> {string.Join(" ", grades)} (avg: {s.Value.Sum() / s.Value.Count:f2})");
}