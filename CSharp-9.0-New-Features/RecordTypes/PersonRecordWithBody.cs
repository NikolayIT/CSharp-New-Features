using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    public record PersonRecordWithBody(string FirstName, string LastName)
    {
        public string FullName => $"{this.FirstName} {this.LastName}";
    }
}
