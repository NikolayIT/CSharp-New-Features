namespace RecordTypes
{
    public record StudentRecord(string FirstName, string LastName, DateTime BirthDate, string Univesity) : PersonRecord(FirstName, LastName, BirthDate);

    // Classes cannot inherit from records: public class Student : PersonRecord { }
}
