namespace PersonsInfo;

public class Person
{
    public string FirstName { set; get; }
    public string LasttName { set; get; }
    public int Age { set; get; }

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LasttName = lastName;
        this.Age = age;
    }
    
    public override string ToString()
    {
        return $"{this.FirstName} {this.LasttName} is {this.Age} years old.";
    }
}