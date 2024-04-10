string city = Console.ReadLine();
double sells = double.Parse(Console.ReadLine());

double perecent = 0;

if (city == "Sofia")
{
    if (sells >= 0 && sells <= 500)
    {
        perecent = 5;
    } else if (sells > 500 && sells <= 1000)
    {
        perecent = 7;
    } else if (sells > 1000 && sells <= 10000)
    {
        perecent = 8;
    } else if (sells > 10000)
    {
        perecent = 12;
    }
} else if (city == "Varna")
{
    if (sells >= 0 && sells <= 500)
    {
        perecent = 4.5;
    } else if (sells > 500 && sells <= 1000)
    {
        perecent = 7.5;
    } else if (sells > 1000 && sells <= 10000)
    {
        perecent = 10;
    } else if (sells > 10000)
    {
        perecent = 13;
    }
} else if (city == "Plovdiv")
{
    if (sells >= 0 && sells <= 500)
    {
        perecent = 5.5;
    } else if (sells > 500 && sells <= 1000)
    {
        perecent = 8;
    } else if (sells > 1000 && sells <= 10000)
    {
        perecent = 12;
    } else if (sells > 10000)
    {
        perecent = 14.5;
    }
}

if (perecent != 0)
{
    Console.WriteLine((sells * (perecent / 100)).ToString("0.00"));
}
else
{
    Console.WriteLine("error");
}