namespace DisibileBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var rand = new Random();

            var length = rand.Next(0, 100);
            var intList = new List<int>();

            for (int i = 0; i < length; i++)
            {
                intList.Add(rand.Next());
            }

            var numbers = new NumbersArray(intList);

            var linqNumbers = numbers.ExtractDivisibleBySevenAndThreeLinq();
            var lambdaNumbers = numbers.ExtractDivisibleBySevenAndThreeLambda();

            for (int i = 0; i < linqNumbers.Count(); i++)
            {
                Console.WriteLine(linqNumbers.ElementAt(i));
                Console.WriteLine(lambdaNumbers.ElementAt(i));
            }

        }
    }
}
