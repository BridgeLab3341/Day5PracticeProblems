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
        int[] intarray = { 1, 3, 6, 4, 7, 8, 10, 2, 5, 9 };
        double[] doublearray = { 1.3, 3.3, 6.7, 4.8, 7.3, 8.2, 10.9, 2.2, 5.4, 9.6 };
        char[] chararray = { 'a', 'b', 'c', 'g', 'f', 'e' };
        public void DeleteUsingGenerics<T>(T[] arr, T search) where T : IComparable
        {
            T[] arr1 = new T[10];
            int k = 0;
            int flag = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(search))
                {
                    flag = 1;
                }
                if (flag == 0)
                {
                    arr1[k] = arr[i];
                    k++;
                }
            }
            arr = arr1;
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void DeleteElementInArray()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Array to delete Element \n 1. IntArray \n 2. FloatArray \n 3. CharArray \n 4. Exit ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the element you want to delete");
                        int search = Convert.ToInt32(Console.ReadLine());
                        DeleteUsingGenerics<int>(intarray, search);
                        break;
                    case 2: 
                        Console.WriteLine("Enter the element you want to delete");
                        double search1 = Convert.ToDouble(Console.ReadLine());
                        DeleteUsingGenerics<double>(doublearray, search1);
                        break;
                    case 3:
                        Console.WriteLine("Enter the element you want to delete");
                        char search2 = Convert.ToChar(Console.ReadLine());
                        DeleteUsingGenerics<char>(chararray, search2);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
