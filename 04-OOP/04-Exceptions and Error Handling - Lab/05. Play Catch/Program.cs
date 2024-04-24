int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int counter = 0;

while (counter < 3)
{
    string[] input = Console.ReadLine().Split().ToArray();
    string command = input[0];

    try
    {
        if (command == "Replace")
        {
            int index = int.Parse(input[1]);
            int element = int.Parse(input[2]);
            numbers[index] = element;
        } 
        else if (command == "Print")
        {
            int startIndex = int.Parse(input[1]);
            int endIndex = int.Parse(input[2]);
        
            Console.WriteLine(string.Join(", ", numbers.ToList().GetRange(startIndex, endIndex)));
        
        } else if (command == "Show")
        {
            int index = int.Parse(input[1]);
            Console.WriteLine(numbers[index]);
        }
    } catch (IndexOutOfRangeException)
    {
        Console.WriteLine("The index does not exist!");
        counter++;
    }
    catch (FormatException)
    {
        Console.WriteLine("The variable is not in the correct format!");
        counter++;
    }
}

Console.WriteLine(string.Join(", ", numbers));