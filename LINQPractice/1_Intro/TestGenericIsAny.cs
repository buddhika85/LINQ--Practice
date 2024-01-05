using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Intro
{
    internal class TestGenericIsAny
    {
        public TestGenericIsAny() 
        {
            var nums = new int[] { 1, 200, 3, 4 };
            Console.WriteLine(IsAny(nums, x => x % 2 == 0));     // true
            Console.WriteLine(IsAny(nums, x => x % 2 == 1));     // true
            Console.WriteLine(IsAny(nums, x => x > 100));        // true

            var strs = new string[] { "Quick", "Brown", "Fox" };
            Console.WriteLine(IsAny(strs, x => x.Length >= 5));      // true
            Console.WriteLine(IsAny(strs, x => x.Length >= 10));     // false

            var customers = new Customer[] { 
                new Customer { Id = 1, Name = "Jack" }, 
                new Customer { Id = 2, Name = "Gill" } 
            };
            Console.WriteLine(IsAny(customers, x => x.Name == "John"));     // false - no John
            Console.WriteLine(IsAny(customers, x => x.Name == "Gill"));     // true
        }

        // can accept anyb type - T
        public bool IsAny<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (var item in items)
            {
                if(predicate(item)) 
                    return true;
            }
            return false;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
