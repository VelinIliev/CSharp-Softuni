int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hoursPerDay = (pages / pagesPerHour) / days;

Console.WriteLine(hoursPerDay);