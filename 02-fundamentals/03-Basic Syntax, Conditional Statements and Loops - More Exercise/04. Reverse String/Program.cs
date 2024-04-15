char[] input = Console.ReadLine().ToCharArray();

Array.Reverse(input);

string reversed = new string(input);

Console.WriteLine(reversed);