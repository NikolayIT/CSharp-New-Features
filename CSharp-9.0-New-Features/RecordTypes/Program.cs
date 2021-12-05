using System;

namespace RecordTypes
{
    public static class Program
    {
        public static void Main()
        {
            var personRecord = new PersonRecord("John", "Doe", new DateTime(2021, 1, 1));
            // Read-only: personRecord.FirstName = "Niki";

            // ToString
            Console.WriteLine("personRecord.ToString(): " + personRecord.ToString());

            // Value equality
            var personRecord2 = new PersonRecord("John", "Doe", new DateTime(2021, 1, 1));
            Console.WriteLine("personRecord == personRecord2: " + (personRecord == personRecord2));
            Console.WriteLine("personRecord.Equals(personRecord2): " + personRecord.Equals(personRecord2));

            // Deconstruct
            (string firstName, string lastName, DateTime birthDate) = personRecord;
            Console.WriteLine($"deconstructed personRecord: ({firstName}, {lastName}, {birthDate.ToShortDateString()})");

            // Records with body
            var recordWithBody = new PersonRecordWithBody("John", "Doe");
            Console.WriteLine("recordWithBody.FullName: " + recordWithBody.FullName);

            // Student inherited from Person
            var student = new StudentRecord("John", "Doe", new DateTime(2021, 1, 1), "Sofia University");
            Console.WriteLine("student.FirstName: " + student.FirstName);

            // Mutation
            var newPerson = personRecord with { FirstName = "Niki", LastName = "Kostov" };
            Console.WriteLine("newPerson.ToString(): " + newPerson.ToString());
        }
    }
}
