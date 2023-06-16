namespace Day5PracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Choose Option To Perform\n1.Delete Element in an Array\n2.Delete Element in an Array Using Generics Method\n3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                DeleteArray array = new DeleteArray();

                switch (option)
                {
                    case 1:
                        array.DeleteElementInArray();
                        break;
                    case 2:
                        array.DeleteElementInArrayUsingGenerics();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
