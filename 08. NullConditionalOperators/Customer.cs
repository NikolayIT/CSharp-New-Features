namespace _8.NullConditionalOperators
{
    using System.Collections.Generic;

    public class Customer
    {
        public Customer()
        {
            this.Orders = new List<string>();
        }

        public IEnumerable<string> Orders { get; set; }
    }
}
