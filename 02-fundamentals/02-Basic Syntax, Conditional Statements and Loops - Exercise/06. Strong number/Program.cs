int number = int.Parse(Console.ReadLine());
string strNumber = number.ToString();

int sumFactorial = 0;

for (int i = 0; i < strNumber.Length; i++)
{
    int currentFactorial = 1;
    
    for (int j = int.Parse(strNumber[i].ToString()); j > 0; j--)
    {
        currentFactorial *= j;
    }

    sumFactorial += currentFactorial;
}

if (sumFactorial == number)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}