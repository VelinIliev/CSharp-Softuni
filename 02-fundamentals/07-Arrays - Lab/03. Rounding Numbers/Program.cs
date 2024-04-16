// string[] input = Console.ReadLine().Split();
// double[] numbers = new double[input.Length];
//
// for (int i = 0; i < input.Length; i++)
// {
//     numbers[i] = double.Parse(input[i]);
// }

double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

foreach (double number in numbers)
{
    int roundedNumber = (int)Math.Round(number, MidpointRounding.AwayFromZero);
    Console.WriteLine($"{number} => {roundedNumber}");   
}