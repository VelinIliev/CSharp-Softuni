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

            Person person = new Person(firstName, lastName, age);
            persons.Add(person);
        }
        
        persons
            .OrderBy(p=> p.FirstName)
            .ThenBy(p=> p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
        
    }
}