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
        public void DeleteElementInArrayUsingGenerics()
        {
            object[] array = { 10, 3.14, 'A', 5, 2.71, 'B', 'C', 7 };
            array = DeleteMethod(array, typeof(int), typeof(double));
            Console.WriteLine("Modified Array");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static object[] DeleteMethodGenerics<T1, T2>(object[] array)
        {
            object[] newArray = new object[array.Length];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (!(array[i] is T1) && !(array[i] is T2))
                {
                    // Copy the element to the new array if it doesn't match the specified types
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }
            Array.Resize(ref newArray, newIndex);

            return newArray;
        }
    }
}
