namespace PersonsInfo;

public class StartUp
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        
        List<Person> persons = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            string[] info = Console.ReadLine().Split();
            string firstName = info[0];
            string lastName = info[1];
            int age = int.Parse(info[2]);
            decimal salary = decimal.Parse(info[3]);

            Person person = new Person(firstName, lastName, age, salary);
            persons.Add(person);
        }

        decimal percentage = decimal.Parse(Console.ReadLine());
        
        persons.ForEach(p => p.IncreaseSalary(percentage));
        persons.ForEach(p => Console.WriteLine(p.ToString()));
    }
}