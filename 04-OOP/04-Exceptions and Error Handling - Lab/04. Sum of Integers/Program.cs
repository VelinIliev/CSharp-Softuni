string[] input = Console.ReadLine().Split();

List<int> valid = new List<int>();

foreach (var el in input)
{
    try
    {
        int currentElement = int.Parse(el);
        valid.Add(currentElement);
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{el}' is out of range!");
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{el}' is in wrong format!");
    }
    finally
    {
        Console.WriteLine($"Element '{el}' processed - current sum: {valid.Sum()}");
    }
}
Console.WriteLine($"The total sum of all integers is: {valid.Sum()}");