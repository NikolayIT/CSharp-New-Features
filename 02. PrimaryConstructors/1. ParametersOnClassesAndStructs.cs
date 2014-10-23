namespace _2.PrimaryConstructors
{
    /// <summary>
    /// C# 6.0 Person Class with Primary Constructor
    /// </summary>
    public class Person(string firstName, string lastName)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
    }

    /// <summary>
    /// C# 5.0 Person Class with Regular Constructor
    /// </summary>
    public class PersonClassCSharp5
    {
        private string firstName;
        private string lastName;

        public PersonClassCSharp5(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }
    }
}
