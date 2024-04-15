string number = Console.ReadLine();

string[] names = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
int index = int.Parse(number.Last().ToString());

Console.WriteLine(names[index]);