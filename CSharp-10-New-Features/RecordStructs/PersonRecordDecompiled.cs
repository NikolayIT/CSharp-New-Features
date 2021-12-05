using System;
using System.Collections.Generic;
using System.Text;

namespace RecordStructs
{
    public struct PersonRecordDecompiled
	{
		public string FirstName { get; set; } // { get; init; } when readonly

		public string LastName { get; set; } // { get; init; } when readonly

		public DateTime BirthDate { get; set; } // { get; init; } when readonly

		public PersonRecordDecompiled(string FirstName, string LastName, DateTime BirthDate)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.BirthDate = BirthDate;
		}

		public override readonly string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PersonRecord");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		private readonly bool PrintMembers(StringBuilder builder)
		{
			builder.Append("FirstName = ");
			builder.Append((object?)FirstName);
			builder.Append(", LastName = ");
			builder.Append((object?)LastName);
			builder.Append(", BirthDate = ");
			builder.Append(BirthDate.ToString());
			return true;
		}

		public static bool operator !=(PersonRecordDecompiled left, PersonRecordDecompiled right)
		{
			return !(left == right);
		}

		public static bool operator ==(PersonRecordDecompiled left, PersonRecordDecompiled right)
		{
			return left.Equals(right);
		}

		public override readonly int GetHashCode()
		{
			return (EqualityComparer<string>.Default.GetHashCode(FirstName) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName)) * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(BirthDate);
		}

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override readonly bool Equals(object obj)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        {
			return obj is PersonRecord && Equals((PersonRecord)obj);
		}

		public readonly bool Equals(PersonRecord other)
		{
			return EqualityComparer<string>.Default.Equals(FirstName, other.FirstName) && EqualityComparer<string>.Default.Equals(LastName, other.LastName) && EqualityComparer<DateTime>.Default.Equals(BirthDate, other.BirthDate);
		}

		public readonly void Deconstruct(out string FirstName, out string LastName, out DateTime BirthDate)
		{
			FirstName = this.FirstName;
			LastName = this.LastName;
			BirthDate = this.BirthDate;
		}
	}
}
