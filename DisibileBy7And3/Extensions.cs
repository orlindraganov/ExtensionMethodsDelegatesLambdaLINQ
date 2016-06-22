namespace DisibileBy7And3
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static IEnumerable<int>ExtractDivisibleBySevenAndThreeLambda(this NumbersArray numbers)
        {
            var result = new List<int>(numbers.Numbers);
            return result
                .Where(x => x % 21 == 0);
        }

        public static IEnumerable<int>ExtractDivisibleBySevenAndThreeLinq(this NumbersArray numbers)
        {
            var intList = new List<int>(numbers.Numbers);
            var result = from number in intList
                         where number % 21 == 0
                         select number;

            return result;
        }
    }
}
