using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Intro
{
    internal class TestLambdaExpressions
    {
        public TestLambdaExpressions()
        {
            var nums = new int[] { 1, 200, 3, 4 };               
            Console.WriteLine(IsAny(nums, x => x % 2 == 0));     // true
            Console.WriteLine(IsAny(nums, x => x % 2 == 1));     // true
            Console.WriteLine(IsAny(nums, x => x > 100));        // true
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
    }
}
