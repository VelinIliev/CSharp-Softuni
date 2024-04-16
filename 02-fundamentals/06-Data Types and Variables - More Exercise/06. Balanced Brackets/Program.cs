int lines = int.Parse(Console.ReadLine());

bool start = false;
bool isBalanced = true;
int openBrackets = 0;
int closedBrackets = 0;

for (int i = 0; i < lines; i++)
{
    string input = Console.ReadLine();
    
    if (input == "(" && start == false)
    {
        start = true;
        openBrackets++;
    } else if (input == "(" && start == true)
    {
        start = false;
        isBalanced = false;
        openBrackets++;
    } else if (input == ")" && start == true )
    {
        start = false;
        closedBrackets++;
    } else if (input == ")" && start == false )
    {
        isBalanced = false;
        closedBrackets++;
    }
}

if (closedBrackets - openBrackets != 0)
{
    isBalanced = false;
} 

if (isBalanced)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}