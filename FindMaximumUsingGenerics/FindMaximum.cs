using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class FindMaximum
    {
        public int FindMaxInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is greater: " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is greater: " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third Number is greater: " + third);
                return third;
            }
        }
        public float FindMaxFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Float Number is greater: " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Float Number is greater: " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third Float Number is greater: " + third);
                return third;
            }
        }
        public string FindMaxString(string first, string second, string third)
        {
            int first_Length = first.Length;
            int second_Length = second.Length;
            int third_Length = third.Length;
            if (first_Length.CompareTo(second_Length) > 0 && first_Length.CompareTo(third_Length) > 0)
            {
                Console.WriteLine("First String Length is greater: " + first);
                return first;
            }
            if (second_Length.CompareTo(first_Length) > 0 && second_Length.CompareTo(third_Length) > 0)
            {
                Console.WriteLine("Second String Length is greater: " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third String Length is greater: " + third);
                return third;
            }
        }
    }
}