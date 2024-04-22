using System.Text.RegularExpressions;

string numbers = Console.ReadLine();

string regex = @"(\+359 2 (\d{3} \d{4}\b))|(\+359-2-(\d{3}-\d{4}\b))";

MatchCollection matchedNumbers = Regex.Matches(numbers, regex);

Console.WriteLine(string.Join(", ", matchedNumbers));