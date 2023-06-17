using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    public class FindMinimum
    {
        public void FindMinInteger<T>(T a, T b, T c) where T : IComparable
        {
          if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0 || a.CompareTo(b) <= 0 && a.CompareTo(c) < 0 || a.CompareTo(b) < 0 && a.CompareTo(c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", a);
            }
            if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0 || b.CompareTo(a) <= 0 && b.CompareTo(c) < 0 || b.CompareTo(a) < 0 && b.CompareTo(c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", b);
            }
            if (c.CompareTo(a) < 0 && c.CompareTo(b) < 0 || c.CompareTo(a) <= 0 && c.CompareTo(b) < 0 || c.CompareTo(a) < 0 && c.CompareTo(b) <= 0)
            {
                Console.WriteLine("{0} is Minimum", c);
            }
        }
        public void FindMinFloat<T>(T a, T b, T c) where T : IComparable
        {
            if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0 || a.CompareTo(b) <= 0 && a.CompareTo(c) < 0 || a.CompareTo(b) < 0 && a.CompareTo(c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", a);
            }
            if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0 || b.CompareTo(a) <= 0 && b.CompareTo(c) < 0 || b.CompareTo(a) < 0 && b.CompareTo(c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", b);
            }
            if (c.CompareTo(a) < 0 && c.CompareTo(b) < 0 || c.CompareTo(a) <= 0 && c.CompareTo(b) < 0 || c.CompareTo(a) < 0 && c.CompareTo(b) <= 0)
            {
                Console.WriteLine("{0} is Minimum", c);
            }
        }
        public void FindMinStrings<T>(T a, T b, T c) where T : IComparable
        {
            if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0 || a.CompareTo(b) <= 0 && a.CompareTo(c) < 0 || a.CompareTo(b) < 0 && a.CompareTo(c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", a);
            }
            if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0 || b.CompareTo(a) <= 0 && b.CompareTo(c) < 0 || b.CompareTo(a) < 0 && b.CompareTo(c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", b);
            }
            if (c.CompareTo(a) < 0 && c.CompareTo(b) < 0 || c.CompareTo(a) <= 0 && c.CompareTo(b) < 0 || c.CompareTo(a) < 0 && c.CompareTo(b) <= 0)
            {
                Console.WriteLine("{0} is Minimum", c);
            }
        }
    }
}
