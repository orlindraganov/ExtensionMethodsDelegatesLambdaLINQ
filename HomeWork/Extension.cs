namespace Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public static class Extension
    {
        #region StringBuilder Extensions
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
        #endregion

        #region IEnumerable<int> Extensions
        public static BigInteger Sum(this IEnumerable<int> intList)
        {
            BigInteger sum = 0;
            foreach (int num in intList)
            {
                sum += num;
            }
            return sum;
        }

        public static BigInteger Product(this IEnumerable<int> intList)
        {
            BigInteger product = 1;

            foreach (int num in intList)
            {
                product *= num;
            }

            return product;
        }

        public static int FindMax(this IEnumerable<int> intList)
        {
            int max = int.MinValue;

            foreach (int num in intList)
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
            int min = int.MaxValue;

            foreach (int num in intList)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }

        public static int FindAvg(this IEnumerable<int> intList)
        {
            BigInteger sum = intList.Sum();
            BigInteger average = sum / (long)intList.Count();

            return (int)average;
        }
        #endregion

        #region IEnumerable<double> Estensions
        public static double Sum(this IEnumerable<double> doubleList)
        {
            double sum = 0;
            foreach (var num in doubleList)
            {
                sum += num;
            }
            return sum;
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

        public static double FindAvg(this IEnumerable<double> doubleList)
        {
            double sum = doubleList.Sum();
            double average = sum / doubleList.Count();

            return average;
        }
        #endregion
    }
}
