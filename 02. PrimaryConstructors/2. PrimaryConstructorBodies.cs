using System;

public class PersonWithPrimaryConstructorBody(string firstName, string lastName)
{
    {
        if (firstName == null)
        {
            throw new ArgumentNullException("firstName");
        }

        if (lastName == null)
        {
            throw new ArgumentNullException("lastName");
        }
    }

    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
}
