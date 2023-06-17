using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    public class FindMinimum<T> where T : IComparable
    {
        T a, b, c;
        public FindMinimum(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void FindMin()
        {
            if (this.a.CompareTo(b) < 0 && this.a.CompareTo(this.c) < 0 || this.a.CompareTo(this.b) <= 0 && this.a.CompareTo(this.c) < 0 || this.a.CompareTo(this.b) < 0 && this.a.CompareTo(this.c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", this.a);
            }
            if (this.b.CompareTo(this.a) < 0 && b.CompareTo(this.c) < 0 || this.b.CompareTo(this.a) <= 0 && this.b.CompareTo(this.c) < 0 || this.b.CompareTo(this.a) < 0 && this.b.CompareTo(this.c) <= 0)
            {
                Console.WriteLine("{0} is Minimum", this.b);
            }
            if (this.c.CompareTo(this.a) < 0 && this.c.CompareTo(this.b) < 0 || this.c.CompareTo(this.a) <= 0 && this.c.CompareTo(this.b) < 0 || this.c.CompareTo(this.a) < 0 && this.c.CompareTo(this.b) <= 0)
            {
                Console.WriteLine("{0} is Minimum", this.c);
            }
        }
    }
}

