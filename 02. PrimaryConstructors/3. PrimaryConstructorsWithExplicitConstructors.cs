public class PersonWithFewConstructors(string firstName, string lastName)
{
    public PersonWithFewConstructors()
        : this("Nikolay", "Kostov") // Without this line the code will not compile
    {
    }

    public PersonWithFewConstructors(int age)
        : this() // This will call indirectly the primary constructor
    {
    }

    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
}
