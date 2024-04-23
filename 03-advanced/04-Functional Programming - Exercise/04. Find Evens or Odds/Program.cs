List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

string oddOrEven = Console.ReadLine();

int start = input[0];
int end = input[1];

List<int> numbers = new List<int>();

for (int i = start; i <= end; i++)
{
    numbers.Add(i);
}

Func<int, bool> func =  oddOrEven switch
{
    "odd" => x => x % 2 != 0,
    "even" => x => x % 2 == 0,
};

Console.WriteLine(string.Join(" ", numbers.Where(func)));