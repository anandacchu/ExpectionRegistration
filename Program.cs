namespace ExceptionRegistration
{
    class program
    {
        public static void Main(string[] args)
        {
            try
            {

                int[] a = new int[3];

                a[0] = 1;
                a[1] = 2;
                a[2] = 34;

                int c = 11, b = 10;
                int d = c / b;

                Console.WriteLine("LineExcueted");

                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }


            }
            catch (IndexOutOfRangeException e)
            {
                console.writeline(e.Message);
            }
        }
    }
}
