namespace DisibileBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class NumbersArray
    {
        private int[] numbers;

        public int[] Numbers
        {
            get
            {
                return this.numbers;
            }
            set
            {
                this.numbers = value;
            }
        }

        public NumbersArray(IEnumerable<int> numbers)
        {
            int numbersCount = numbers.Count();
            this.Numbers = new int[numbersCount];
            Numbers = numbers.ToArray();
        }
    }
}
