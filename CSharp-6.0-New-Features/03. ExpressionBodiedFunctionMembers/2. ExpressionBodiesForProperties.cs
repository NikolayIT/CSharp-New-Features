using System.Collections.Generic;
using System.Linq;

public class Person
{
    public Person()
    {
        this.Children = new List<Person>();
    }

    public Person(string firstName, string lastName)
    {
        this.Children = new List<Person>();
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public List<Person> Children { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    // Before:
    //// public string Name
    //// {
    ////     get
    ////     {
    ////         return this.FirstName + " " + this.LastName;
    ////     }
    //// }
    // After:
    public string Name => this.FirstName + " " + this.LastName;

    // Expression for indexer body:
    public Person this[string name] =>
        this.Children.FirstOrDefault(
            x => x.Name.ToLower().Contains(name.ToLower()));
}
