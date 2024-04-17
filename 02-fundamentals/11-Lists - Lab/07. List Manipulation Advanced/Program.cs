List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
bool isListChanged = false;

while (true)
{
    string input = Console.ReadLine();
    
    if (input == "end")
    {
        break;
    } 
    string[] conditions = input.Split().ToArray();
    string action = conditions[0];
    
    
    if (action == "Add")
    {
        int number = int.Parse(conditions[1]);
        numbers.Add(number);
        isListChanged = true;
    } 
    else if (action == "Remove")
    {
        int number = int.Parse(conditions[1]);
        numbers.Remove(number);
        isListChanged = true;
    } 
    else if (action == "RemoveAt")
    {
        int number = int.Parse(conditions[1]);
        numbers.RemoveAt(number);
        isListChanged = true;
    } 
    else if (action == "Insert")
    {   
        int number = int.Parse(conditions[1]);
        int index = int.Parse(conditions[2]);
        numbers.Insert(index, number);
        isListChanged = true;
    } 
    else if(action == "Contains")
    {
        int number = int.Parse(conditions[1]);
        
        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    } 
    else if (action == "PrintEven")
    {
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    } 
    else if (action == "PrintOdd")
    {
        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    } 
    else if (action == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    } 
    else if (action == "Filter")
    {
        List<int> filtered = new List<int>();
        
        string operators = conditions[1];
        int number = int.Parse(conditions[2]);

        foreach (int num in numbers)
        {
            if (operators == "<")
            {
                if (num < number)
                {
                    filtered.Add(num);
                }   
            }  
            else if (operators == ">")
            {
                if (num > number)
                {
                    filtered.Add(num);
                }
            } 
            else if (operators == "<=")
            {
                if (num <= number)
                {
                    filtered.Add(num);
                }
            } 
            else if (operators == ">=")
            {
                if (num >= number) { filtered.Add(num); }
            }
        }
        Console.WriteLine(string.Join(" ", filtered));
    }
}

if (isListChanged)
{
    Console.WriteLine(string.Join(" ", numbers));
}