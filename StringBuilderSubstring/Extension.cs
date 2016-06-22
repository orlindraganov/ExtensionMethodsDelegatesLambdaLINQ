using System.Collections.Generic;
using System.Text;

namespace StringBuilderSubstring
{
    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder strbldr, int startIndex)
        {
            Validator.ValidateStartIndex(strbldr, startIndex);
            strbldr.Remove(0, startIndex);
            return strbldr;
        }

        public static StringBuilder Substring(this StringBuilder strbldr, int startIndex, int length)
        {
            Validator.ValidateStartIndex(strbldr, startIndex);
            Validator.ValidateLength(strbldr, startIndex, length);

            int remainingLength;

            strbldr.Remove(0, startIndex);
            remainingLength = strbldr.Length;
            strbldr.Remove(length, remainingLength - length);
            return strbldr;
        }

        public static long Sum(this IEnumerable<int> intList)
        {
            long sum = 0;
            foreach (var num in intList)
            {
                sum += 0;
            }
            return sum;
        }

        public static double Sum(this IEnumerable<double> doubleList)
        {
            double sum = 0;
            foreach (var num in doubleList)
            {
                sum += 0;
            }
            return sum;
        }

        public static long Product(this IEnumerable<int> intList)
        {
            long product = 1;

            foreach (var num in intList)
            {
                product *= num;
            }

            return product;
        }

        public static double Product(this IEnumerable<double> doubleList)
        {
            double product = 1;

            foreach (var num in doubleList)
            {
                product *= num;
            }

            return product;
        }

        public static int FindMax(this IEnumerable<int> intList)
        {
            int max = int.MinValue;

            foreach (var num in intList)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }

        public static double FindMax(this IEnumerable<double> doubleList)
        {
            double max = double.MinValue;

            foreach (var num in doubleList)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }

        public static int FindMin(this IEnumerable<int> intList)
        {
            int min = int.MinValue;

            foreach (var num in intList)
                            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }

        public static double FindMin(this IEnumerable<double> doubleList)
        {
            double min = double.MaxValue;

            foreach (var num in doubleList)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
