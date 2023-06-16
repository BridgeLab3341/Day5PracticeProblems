using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    public class DeleteArray
    {
        public void DeleteElementInArray()
        {
            object[] array = { 10, 3.14, 'A', 5, 2.71, 'B', 'C', 7 };
            array =DeleteMethod(array, typeof(int),typeof(double));
            Console.WriteLine("Modified Array");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static object[] DeleteMethod(object[] array, params Type[] types)
        {
            for(int i= array.Length - 1; i>=0; i--)
            {
                foreach(Type type in types)
                {
                    if (array[i].GetType() == type)
                    {
                        // Delete the element at index i by shifting all subsequent elements to the left
                        for (int j=i; j < array.Length -1; j++)
                        {
                            array[j] = array[j+1];
                        }
                        // Resize the array to exclude the deleted element
                        Array.Resize(ref array, array.Length - 1);
                        break;// Found a matching type, no need to continue the inner loop
                    }
                }
            }
            return array;
        }      
    }
}
