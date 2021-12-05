using System;

namespace InitOnlyProperties
{
    public class Person
    {
        private int age;

        // Init-only property
        public string Name { get; init; }

        // Init-only property
        public int Age
        {
            get => this.age;
            init
            {
                if (this.age < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this.age = value;

                // this.Name can be set here
            }
        }

        // Read-only property -> can be set only in constructor
        public DateTime BirthDate { get; }

        public Person()
        {
            this.BirthDate = DateTime.Now;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} is {this.Age} years old.";
        }
    }
}
