int numberOfWagons = int.Parse(Console.ReadLine());
int[] wagons = new int[numberOfWagons] ;

for (int i = 0; i < numberOfWagons; i++)
{
    int passengers = int.Parse(Console.ReadLine());
    wagons[i] = passengers;
}

Console.WriteLine(string.Join(" ", wagons));
Console.WriteLine(wagons.Sum());