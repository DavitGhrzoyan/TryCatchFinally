using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine("The result is" + y);
            }
            catch
            {
                Console.WriteLine("ERROR ERROR !!!!!!:  attemt devive by zero");
            }
            finally
            {
                Console.WriteLine("finish: finally");
            }
            Console.WriteLine("the end of code");
        }
    }
}
