using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class FindMaximumNum<T> where T : IComparable
    {
        public T[] value;

        public FindMaximumNum(T[] value)
        {
            this.value = value;
        }
        public static T[] Sort<T>(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public static T MaxValue<T>(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T PrintMaxMethod()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is :" + max);
            return max;
        }
    }
}