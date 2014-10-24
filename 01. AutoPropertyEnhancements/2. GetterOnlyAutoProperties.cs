public class ReadOnlyPerson
{
    public string FirstName { get; } = "Nikolay";
    public string LastName { get; } = "Kostov";

    public ReadOnlyPerson()
    {
        // In future versions the next line will be valid C# read-only propery initialization
        // this.FirstName = "test";
    }
}
