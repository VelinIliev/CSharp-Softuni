int numberOfGroups = int.Parse(Console.ReadLine());

int musala = 0;
int montblan = 0;
int kilimandjaro = 0;
int k2 = 0;
int everest = 0;

int totalPepople = 0;

for (int i = 0; i < numberOfGroups; i++)
{
    int groupSize = int.Parse(Console.ReadLine());
    if (groupSize <= 5)
    {
        musala += groupSize;
    } else if (groupSize <= 12)
    {
        montblan += groupSize;
    } else if (groupSize <= 25)
    {
        kilimandjaro += groupSize;
    } else if (groupSize <= 40)
    {
        k2 += groupSize;
    }
    else
    {
        everest += groupSize;
    }

    totalPepople += groupSize;
}

Console.WriteLine($"{(double)musala/totalPepople*100:f2}%");
Console.WriteLine($"{(double)montblan/totalPepople*100:f2}%");
Console.WriteLine($"{(double)kilimandjaro/totalPepople*100:f2}%");
Console.WriteLine($"{(double)k2/totalPepople*100:f2}%");
Console.WriteLine($"{(double)everest/totalPepople*100:f2}%");