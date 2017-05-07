public class ReadOnlyPerson
{
    public string FirstName { get; } = "Nikolay";

    public string LastName { get; } = "Kostov";

    public ReadOnlyPerson(string firstName)
    {
        // This line is also valid for read-only property initialization
        this.FirstName = firstName;
    }
}
