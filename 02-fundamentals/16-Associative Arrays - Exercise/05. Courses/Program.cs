Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

while (true)
{
    string[] info = Console.ReadLine().Split(" : ");
    if (info[0] == "end")
    {
        break;
    }
    string courseName = info[0];
    string studentName = info[1];

    if (courses.ContainsKey(courseName))
    {
        courses[courseName].Add(studentName);
    }
    else
    {
        courses.Add(courseName, new List<string>());
        courses[courseName].Add(studentName);
    }
}

foreach (var c in courses)
{
    Console.WriteLine($"{c.Key}: {c.Value.Count}");
    foreach (var student in c.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}