int primeNumbersSum = 0;
int nonPrimeNumbersSum = 0;

bool isPrime(int num) {
    if (num <= 1) {
        return false;
    }
    if (num <= 3) {
        return true;
    }
    if (num % 2 == 0 || num % 3 == 0) {
        return false;
    }

    for (int i = 5; i * i <= num; i += 6) {
        if (num % i == 0 || num % (i + 2) == 0) {
            return false;
        }
    }

    return true;
}

while (true)
{
    string input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }

    int number = int.Parse(input);
    
    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
    }
    else if (isPrime(number))
    {
        primeNumbersSum += number;
    }
    else
    {
        nonPrimeNumbersSum += number;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");