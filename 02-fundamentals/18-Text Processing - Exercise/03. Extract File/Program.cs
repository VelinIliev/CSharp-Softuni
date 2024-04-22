string[] input = Console.ReadLine().Split("\\").ToArray();

string[] file = input.Last().Split(".").ToArray();

string fileName = file[0];
string extension = file[1];

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extension}");