namespace NotImplemeted
{
    using System.Collections.Generic;

    public class JObject
    {
        private Dictionary<string, string> data;

        public JObject()
        {
            this.data = new Dictionary<string, string>();
        }

        public string this[string index]
        {
            get
            {
                if (!this.data.ContainsKey(index))
                {
                    this.data.Add(index, string.Empty);
                }

                return this.data[index];
            }
            set
            {
                if (!this.data.ContainsKey(index))
                {
                    this.data.Add(index, value);
                }
                else
                {
                    this.data[index] = value;
                }
            }
        }
    }
}
