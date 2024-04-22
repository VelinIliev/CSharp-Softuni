List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

Queue<int> queue = new Queue<int>(numbers.Where(x=> x % 2 == 0));

Console.WriteLine(string.Join(", ", queue));