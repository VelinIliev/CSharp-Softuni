string str = "";

for (int i = 0; i < 3; i++)
{ 
    str += $" {Console.ReadLine()}";
}
char[] charArray = str.ToCharArray();
Array.Reverse(charArray);

Console.WriteLine(new string(charArray));