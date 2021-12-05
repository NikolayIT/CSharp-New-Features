using System;

namespace RecordStructs
{
    public static class Program
    {
        public static void Main()
        {
            var personRecord = new PersonRecord("John", "Doe", new DateTime(2021, 1, 1));

            // ToString
            Console.WriteLine("personRecord.ToString(): " + personRecord.ToString());

            // Value equality
            var personRecord2 = new PersonRecord("John", "Doe", new DateTime(2021, 1, 1));
            Console.WriteLine("personRecord == personRecord2: " + (personRecord == personRecord2));
            Console.WriteLine("personRecord.Equals(personRecord2): " + personRecord.Equals(personRecord2));

            // Non-readonly
            personRecord.FirstName = "Niki";
            personRecord.LastName = "Kostov";

            // Deconstruct
            (string firstName, string lastName, DateTime birthDate) = personRecord;
            Console.WriteLine($"deconstructed personRecord: ({firstName}, {lastName}, {birthDate.ToShortDateString()})");

            // Read-only record
            var readOnlyRecord = new ReadOnlyPersonRecord("Read", "Only", DateTime.Now);
            Console.WriteLine(readOnlyRecord);
            // Not available: readOnlyRecord.FirstName = firstName;
        }
    }
}
