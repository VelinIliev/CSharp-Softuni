double depositAmount = double.Parse(Console.ReadLine());

int months = int.Parse(Console.ReadLine());

double percent = double.Parse(Console.ReadLine()) / 100;

double sum = depositAmount + months * ((depositAmount * percent) / 12);

Console.WriteLine(sum);