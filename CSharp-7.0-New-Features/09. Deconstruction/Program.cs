using System;

public static class Program
{
    public static void Main()
    {
        // Deconstruct with Deconstruct() method
        var fullName = new FullName("N", "S", "K");
        (string fn, string mn, string ln) = fullName;
        Console.WriteLine($"{fn} {mn} {ln}");

        // Deconstruct with extension method
        (int year, int month, int day) = DateTime.Now;
        Console.WriteLine($"{day}.{month}.{year}");
    }

    public class FullName
    {
        public FullName(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public void Deconstruct(out string firstName, out string middleName, out string lastName)
        {
            firstName = this.FirstName;
            middleName = this.MiddleName;
            lastName = this.LastName;
        }
    }

    private static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day)
    {
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
    }
}
