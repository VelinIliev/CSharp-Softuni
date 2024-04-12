double ticketsTotal = 0;
double totalStudentTickets = 0;
double totalStandartTickets = 0;
double totalKidTickets = 0;

while (true)
{
    string movieName = Console.ReadLine();
    if (movieName == "Finish")
    {
        break;
    }

    int freePlaces = int.Parse(Console.ReadLine());

    double soldTickets = 0;
    double soldStudentTickets = 0;
    double soldStandartTickets = 0;
    double soldKidTickets = 0;

    while (freePlaces != soldTickets)
    {
        string ticketType = Console.ReadLine();
        if (ticketType == "End")
        {
            break;
        } else if (ticketType == "student")
        {
            soldStudentTickets += 1;
        } else if (ticketType == "standard")
        {
            soldStandartTickets += 1;
        } else if (ticketType == "kid")
        {
            soldKidTickets += 1;
        }
        soldTickets += 1;
    }
    Console.WriteLine($"{movieName} - {((soldTickets / freePlaces) * 100):f2}% full.");
    ticketsTotal += soldTickets;
    totalStudentTickets += soldStudentTickets;
    totalStandartTickets += soldStandartTickets;
    totalKidTickets += soldKidTickets;
}

Console.WriteLine($"Total tickets: {ticketsTotal}");
Console.WriteLine($"{totalStudentTickets/ticketsTotal*100:f2}% student tickets.");
Console.WriteLine($"{totalStandartTickets/ticketsTotal*100:f2}% standard tickets.");
Console.WriteLine($"{totalKidTickets/ticketsTotal*100:f2}% kids tickets.");