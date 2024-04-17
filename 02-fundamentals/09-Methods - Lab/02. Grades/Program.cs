double grade = double.Parse(Console.ReadLine());

string ConvertGrade(double grade)
{
    string output = "";
    
    switch (grade)
    {
        case < 3: output = "Fail"; break;
        case < 3.5: output = "Poor"; break;
        case < 4.5: output = "Good"; break;
        case < 5.5: output = "Very good"; break;
        case <= 6: output =  "Excellent"; break;
    }

    return output;
}

Console.WriteLine(ConvertGrade(grade));