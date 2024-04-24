try
{
    uint number = uint.Parse(Console.ReadLine());

    Console.WriteLine(Math.Sqrt(number));
}
catch (OverflowException ex)
{
    Console.WriteLine("Invalid number.");
}
catch (FormatException)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}