public class ReadOnlyPerson
{
    public string FirstName { get; } = "Nikolay";

    public string LastName { get; } = "Kostov";

    public ReadOnlyPerson()
    {
        // This line is also valid for read-only property initialization
        this.FirstName = "test";
    }
}
