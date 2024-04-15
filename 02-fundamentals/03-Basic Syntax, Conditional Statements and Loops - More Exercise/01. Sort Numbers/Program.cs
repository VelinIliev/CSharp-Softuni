int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int[] numbers = {n1, n2, n3};
Array.Sort(numbers);
Array.Reverse(numbers);

foreach (var x in numbers)
{
    Console.WriteLine(x);
}