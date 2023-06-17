using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    public class DeleteArray<T> where T : IComparable
    {
        T[] array;
        public DeleteArray(T[] array) 
        { 
            this.array = array;
        }
        public void DeleteUsingGenerics(T search)
        {
            T[] arr1 = new T[10];
            int k = 0;
            int flag = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(search))
                {
                    flag = 1;
                }
                if (flag == 0)
                {
                    arr1[k] = array[i];
                    k++;
                }
            }
            array = arr1;
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
