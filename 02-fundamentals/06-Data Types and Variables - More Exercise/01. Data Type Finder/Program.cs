while (true)
{
    string input = Console.ReadLine();
    if (input == "END")
    {
        break;
    }

    string typeOfData = "";
    
    if (int.TryParse(input, out _))
    {
        typeOfData = "integer"; 
    } else if (double.TryParse(input, out _))
    {
        typeOfData = "floating point";
    } else if (bool.TryParse(input, out _))
    {
        typeOfData = "boolean";
    } else if (char.TryParse(input, out _))
    {
        typeOfData = "character";
    }
    else
    {
        typeOfData = "string";
    }
    Console.WriteLine($"{input} is {typeOfData} type");
}