namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(num1, num2));
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(char1, char2));
                    break;
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();

                    Console.WriteLine(GetMax(string1, string2));
                    break;
            }

        }
        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
        static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
    }
}