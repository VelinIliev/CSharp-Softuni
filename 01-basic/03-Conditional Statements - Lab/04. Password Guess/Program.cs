string secretPass = "s3cr3t!P@ssw0rd";

string pass = Console.ReadLine();

if (pass == secretPass)
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Wrong password!");
}