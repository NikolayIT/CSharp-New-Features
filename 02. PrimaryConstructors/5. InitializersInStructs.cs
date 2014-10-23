namespace _2.PrimaryConstructors
{
    public struct Tally(int count, int sum)
    {
        public int Count { get; } = count;
        public int Sum { get; } = sum;
        public double Average
        {
            get
            {
                if (Count == 0)
                {
                    return 0;
                }

                return (double)Sum / Count;
            }
        }
    }
}
