using System;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write down a temperature number: ");
            string temperature = Console.ReadLine();
            Console.WriteLine("C or F? ");
            string unit = Console.ReadLine();
        }
    }
}
