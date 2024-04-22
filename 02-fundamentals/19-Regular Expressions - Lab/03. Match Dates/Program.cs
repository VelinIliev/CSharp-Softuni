using System.Text.RegularExpressions;

string dates = Console.ReadLine();

string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>)\d{4}\b";

var validDates = Regex.Matches(dates, regex);

foreach (Match date in validDates)
{
    var day = date.Groups["day"].Value;
    var month = date.Groups["month"].Value;
    var year = date.Groups["year"].Value;
    
    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
    
}