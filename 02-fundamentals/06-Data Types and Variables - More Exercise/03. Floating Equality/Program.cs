decimal firstNum = decimal.Parse(Console.ReadLine());
decimal secondNum = decimal.Parse(Console.ReadLine());
double eps = 0.000001;
decimal difference = Math.Abs(firstNum - secondNum);

if (difference >= (decimal)eps)
{
    Console.WriteLine(false);
}
else
{
    Console.WriteLine(true);
}
