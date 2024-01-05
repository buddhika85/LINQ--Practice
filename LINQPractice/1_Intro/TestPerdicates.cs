using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Intro
{
    internal class TestPerdicates
    {
        public TestPerdicates()
        {
            var nums = new int[] { 1, 200, 3, 4 };      // true
            Console.WriteLine(IsAny(nums, IsEven));     // true
            Console.WriteLine(IsAny(nums, IsOdd));
            Console.WriteLine(IsAny(nums, IsGreaterThanTwoHundred));        // false
        }

        public bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
        {
            foreach (var item in numbers)
            {
                if (predicate(item))
                    return true;
            }
            return false;
        }

        public bool IsEven(int num) =>  num % 2 == 0;
        public bool IsOdd(int num) => num % 2 == 1;
        public bool IsGreaterThanHundred(int num) => num > 100;
        public bool IsGreaterThanTwoHundred(int num) => num > 200;
    }
}
