using System;

namespace XMLRefExtract
{
    static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                XMLRefExtract processor = new XMLRefExtract();
                processor.Launch();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
