using System;

public class Person
{
    private string firstName;
    private string lastName;

    public Person(string firstName, string lastName)
    {
        if (firstName == null)
        {
            throw new ArgumentNullException("firstName");
        }

        if (lastName == null)
        {
            throw new ArgumentNullException("lastName");
        }

        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string Name
    {
        get
        {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}
