using System;
using System.Text;

namespace StringBuilderSubstring
{
    public static class Validator
    {
        public static void ValidateStartIndex(StringBuilder strbldr, int startIndex)
        {
            if ((startIndex < 0) || (startIndex > strbldr.Length - 1))
            {
                throw new ArgumentOutOfRangeException("startIndex", "Out of StringBuilder length");
            }
        }

        public static void ValidateLength(StringBuilder strbldr, int startIndex, int length)
        {
            if ((length < 0) || (length > strbldr.Length - startIndex - 1))
            {
                throw new ArgumentOutOfRangeException("length", "Out of StringBuilder length");
            }
        }
    }
}
