string book = Console.ReadLine();
int booksCounter = 0;

while (true)
{
    string checkBook = Console.ReadLine();
    
    
    if (checkBook == book)
    {   
        Console.WriteLine($"You checked {booksCounter} books and found it.");
        break;
    }

    if (checkBook == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {booksCounter} books.");
        break;
    }
    booksCounter++;
}