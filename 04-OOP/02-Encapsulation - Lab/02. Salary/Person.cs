namespace PersonsInfo;

public class Person
{
    public string FirstName { private set; get; }
    public string LasttName { private set; get; }
    public int Age { private set; get; }
    public decimal Salary  { private set; get; }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LasttName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age < 30)
        {
            this.Salary *= (100 + percentage / 2) / 100;
        }
        else
        {
            this.Salary *= (100 + percentage) / 100;
        }
    }
    public override string ToString()
    {
        return $"{this.FirstName} {this.LasttName} receives {this.Salary:f2} leva.";
    }
}