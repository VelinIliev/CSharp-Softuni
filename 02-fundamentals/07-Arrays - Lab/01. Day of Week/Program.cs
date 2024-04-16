string[] weekDays =
{
    "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
};

int day = int.Parse(Console.ReadLine());

if (day >= 1 && day <= 7)
{
    Console.WriteLine(weekDays[day]);
}
else
{
    Console.WriteLine(weekDays[0]);
}