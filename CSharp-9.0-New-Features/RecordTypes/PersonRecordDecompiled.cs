using System;
using System.Collections.Generic;
using System.Text;

namespace RecordTypes
{
    public class PersonRecordDecompiled : IEquatable<PersonRecordDecompiled>
    {
        protected virtual Type EqualityContract
        {
            get
            {
                return typeof(PersonRecordDecompiled);
            }
        }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public DateTime BirthDate { get; init; }

        public PersonRecordDecompiled(string FirstName, string LastName, DateTime BirthDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Person");
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(' ');
            }
            stringBuilder.Append('}');
            return stringBuilder.ToString();
        }

        protected virtual bool PrintMembers(StringBuilder builder)
        {
            builder.Append("FirstName = ");
            builder.Append((object?)FirstName);
            builder.Append(", LastName = ");
            builder.Append((object?)LastName);
            builder.Append(", BirthDate = ");
            builder.Append(BirthDate.ToString());
            return true;
        }

        public static bool operator !=(PersonRecordDecompiled? left, PersonRecordDecompiled? right)
        {
            return !(left == right);
        }

        public static bool operator ==(PersonRecordDecompiled? left, PersonRecordDecompiled? right)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            return (object)left == right || (left?.Equals(right) ?? false);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }

        public override int GetHashCode()
        {
            return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName)) * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(BirthDate);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonRecordDecompiled);
        }

        public virtual bool Equals(PersonRecordDecompiled? other)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            return (object)this == other || ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(FirstName, other!.FirstName) && EqualityComparer<string>.Default.Equals(LastName, other!.LastName) && EqualityComparer<DateTime>.Default.Equals(BirthDate, other!.BirthDate));
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }

        protected PersonRecordDecompiled(PersonRecordDecompiled original)
        {
            FirstName = original.FirstName;
            LastName = original.LastName;
            BirthDate = original.BirthDate;
        }

        public void Deconstruct(out string FirstName, out string LastName, out DateTime BirthDate)
        {
            FirstName = this.FirstName;
            LastName = this.LastName;
            BirthDate = this.BirthDate;
        }
    }
}
