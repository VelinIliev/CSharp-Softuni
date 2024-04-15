double money = double.Parse(Console.ReadLine());
double students = double.Parse(Console.ReadLine());
double lightsbearsPrice = double.Parse(Console.ReadLine());
double robesPrice = double.Parse(Console.ReadLine());
double beltsPrice = double.Parse(Console.ReadLine());


double belts = Math.Floor(students / 6);

double total = lightsbearsPrice * Math.Ceiling(students * 1.1) 
               + robesPrice * students + beltsPrice * (students - belts);


if (money - total >= 0)
{
    Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {total - money:f2}lv more.");
}