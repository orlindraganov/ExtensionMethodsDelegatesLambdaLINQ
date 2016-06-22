namespace Extensions
{
    class Startup
    {
        static void Main()
        {
            Tester.TestStringbuilderSubstring(Tester.TestStringStartIndex);
            Tester.TestStringbuilderSubstring(Tester.TestStringStartIndex, Tester.TestStringLength);
            Tester.TestSum(Tester.IntList);
            Tester.TestProduct(Tester.IntList);
            Tester.TestMax(Tester.IntList);
            Tester.TestMin(Tester.IntList);
            Tester.TestAvg(Tester.IntList);
            Tester.TestSum(Tester.DoubleList);
            Tester.TestProduct(Tester.DoubleList);
            Tester.TestMax(Tester.DoubleList);
            Tester.TestMin(Tester.DoubleList);
            Tester.TestAvg(Tester.DoubleList);
        }
    }
}
