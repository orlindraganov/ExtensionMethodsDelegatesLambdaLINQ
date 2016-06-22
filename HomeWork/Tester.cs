namespace Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public static class Tester
    {
        #region Fields
        private static IEnumerable<int> intList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static IEnumerable<double> doubleList = new List<double>() { 0D, 0.3D, 3.1415, 10.34, 14.88 };
        private static string testString = "01234567890123456789";
        private static int testStringStartIndex = 7;
        private static int testStringLength = 5;
        #endregion

        #region Properties
        public static IEnumerable<int> IntList
        {
            get
            {
                return intList;
            }
            set
            {
                intList = value;
            }
        }

        public static IEnumerable<double> DoubleList
        {
            get
            {
                return doubleList;
            }
            set
            {
                doubleList = value;
            }
        }

        public static string TestString
        {
            get
            {
                return testString;
            }
            set
            {
                testString = value;
            }
        }

        public static int TestStringStartIndex
        {
            get
            {
                return testStringStartIndex;
            }
            set
            {
                testStringStartIndex = value;
            }
        }

        public static int TestStringLength
        {
            get
            {
                return testStringLength;
            }
            set
            {
                testStringLength = value;
            }
        }
        #endregion

        #region Testing Substring
        public static void TestStringbuilderSubstring(int startIndex = 7)
        {
            var testBuilder = new StringBuilder();

            testBuilder.Append(testString);
            testBuilder.Substring(startIndex);

            Console.WriteLine(testBuilder);
            Console.WriteLine(testString);
        }

        public static void TestStringbuilderSubstring(int startIndex = 10, int length = 5)
        {
            var testBuilder = new StringBuilder();

            testBuilder.Append(testString);
            testBuilder.Substring(startIndex, length);

            Console.WriteLine(testBuilder);
            Console.WriteLine(testString);
        }
        #endregion

        #region Testing IEnumerable<int> Extensions
        public static void TestSum(IEnumerable<int> intList)
        {
            BigInteger sum = intList.Sum();
            Console.WriteLine(sum);
        }

        public static void TestProduct(IEnumerable<int> intList)
        {
            BigInteger product = intList.Product();
            Console.WriteLine(product);
        }

        public static void TestMax(IEnumerable<int> intList)
        {
            BigInteger max = intList.FindMax();
            Console.WriteLine(max);
        }

        public static void TestMin(IEnumerable<int> intList)
        {
            int min = intList.FindMin();
            Console.WriteLine(min);
        }

        public static void TestAvg(IEnumerable<int> intList)
        {
            int avg = intList.FindAvg();
            Console.WriteLine(avg);
        }
        #endregion

        #region Testing IEnumerable<double> Extensions
        public static void TestSum(IEnumerable<double> doubleList)
        {
            double sum = doubleList.Sum();
            Console.WriteLine(sum);
        }

        public static void TestProduct(IEnumerable<double> doubleList)
        {
            double product = doubleList.Product();
            Console.WriteLine(product);
        }

        public static void TestMax(IEnumerable<double> doubleList)
        {
            double max = doubleList.FindMax();
            Console.WriteLine(max);
        }

        public static void TestMin(IEnumerable<double> doubleList)
        {
            double min = doubleList.FindMin();
            Console.WriteLine(min);
        }

        public static void TestAvg(IEnumerable<double> doubleList)
        {
            double avg = doubleList.FindAvg();
            Console.WriteLine(avg);
        }
        #endregion
    }
}
