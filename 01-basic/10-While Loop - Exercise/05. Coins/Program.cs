double amount = double.Parse(Console.ReadLine());
int coins = 0;

int totalAmount = (int)(amount * 100);

while (true)
{
    if (totalAmount - 200 >= 0)
    {
        totalAmount -= 200;
    } 
    else if (totalAmount - 100 >= 0)
    {
        totalAmount -= 100;
    }
    else if (totalAmount - 50 >= 0)
    {
        totalAmount -= 50;
    }
    else if (totalAmount - 20 >= 0)
    {
        totalAmount -= 20;
    }
    else if (totalAmount - 10 >= 0)
    {
        totalAmount -= 10;
    }
    else if (totalAmount - 5 >= 0)
    {
        totalAmount -= 5;
    }
    else if (totalAmount - 2 >= 0)
    {
        totalAmount -= 2;
    }
    else 
    {
        totalAmount -= 1;
       
    }
    coins++;
    if (totalAmount == 0)
    {
        break;
    }
}

Console.WriteLine(coins);