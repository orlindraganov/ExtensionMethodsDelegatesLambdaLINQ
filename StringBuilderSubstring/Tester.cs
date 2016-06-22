namespace StringBuilderSubstring
{
    using System;
    using System.Text;


    public static class Tester
    {
        public static void TestStringbuilderSubstring(int startIndex)
        {
            var testString = "01234567890123456789";
            
            var testBuilder = new StringBuilder();

            testBuilder.Append(testString);
            testBuilder.Substring(startIndex);

            Console.WriteLine(testBuilder);
            Console.WriteLine(testString);
        }

        public static void TestStringbuilderSubstring(int startIndex, int length)
        {
            var testString = "01234567890123456789";

            var testBuilder = new StringBuilder();

            testBuilder.Append(testString);
            testBuilder.Substring(startIndex, length);

            Console.WriteLine(testBuilder);
            Console.WriteLine(testString);
        }

        
    }
}
