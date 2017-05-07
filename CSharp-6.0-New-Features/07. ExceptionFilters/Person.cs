using System;

public class Person
{
    private readonly string firstName;
    private readonly string lastName;

    public Person(string firstName, string lastName)
    {
        if (firstName == null)
        {
            throw new ArgumentNullException(nameof(firstName));
        }

        if (lastName == null)
        {
            throw new ArgumentNullException(nameof(lastName));
        }

        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string Name => $"{this.firstName} {this.lastName}";
}
