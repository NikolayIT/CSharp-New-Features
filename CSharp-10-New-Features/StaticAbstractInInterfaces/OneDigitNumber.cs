using System;

namespace StaticAbstractInInterfaces
{
    public class OneDigitNumber :
        IParseable<OneDigitNumber>,
        IAdditionOperators<OneDigitNumber, OneDigitNumber, OneDigitNumber>
    {
        public OneDigitNumber(int value)
        {
            this.Value = value % 10;
        }

        public int Value { get; }

        public static OneDigitNumber Parse(string s)
        {
            return new OneDigitNumber(s[0] - '0');
        }

        public static bool TryParse(string s, out OneDigitNumber result)
        {
            if (s?.Length == 1 && s[0] >= '0' && s[0] <= '9')
            {
                result = new OneDigitNumber(s[0] - '0');
                return true;
            }

            result = null;
            return false;
        }

        public static OneDigitNumber operator +(OneDigitNumber left, OneDigitNumber right)
        {
            return new OneDigitNumber(left.Value + right.Value);
        }
    }
}
