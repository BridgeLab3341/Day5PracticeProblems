namespace Day5PracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] IntArray = { 1, 5, 8, 9, 6, 3, 4 };
            //double[] DoubleArray = { 1.1, 5.7, 9.8, 5.6 };
            //char[] CharArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
            //DeleteArray<int> deleteArray = new DeleteArray<int>(IntArray);
            //deleteArray.DeleteUsingGenerics(5);
            //DeleteArray<double> deleteArray1 = new DeleteArray<double>(DoubleArray);
            //deleteArray1.DeleteUsingGenerics(9.8);
            //DeleteArray<char> deleteArray2 = new DeleteArray<char>(CharArray);
            //deleteArray2.DeleteUsingGenerics('d');
            FindMinimum find=new FindMinimum();
            find.FindMinInteger<int>(2,3,4);
            find.FindMinFloat<float>(2.4f,4.5f,1.3f);
            find.FindMinStrings<string>("standard","movie","ticket");
        }
    }
}
