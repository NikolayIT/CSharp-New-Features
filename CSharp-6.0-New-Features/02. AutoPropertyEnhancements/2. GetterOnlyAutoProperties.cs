public class ReadOnlyPerson
{
    public ReadOnlyPerson(string firstName)
    {
        // This line is also valid for read-only property initialization
        this.FirstName = firstName;
    }

    public string FirstName { get; } = "Nikolay";

    public string LastName { get; } = "Kostov";
}
