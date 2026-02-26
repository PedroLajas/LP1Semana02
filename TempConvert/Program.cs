using System;
using Microsoft.VisualBasic;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write down a temperature number: ");
            double temperature = double.Parse(Console.ReadLine());
            Console.WriteLine("C or F? ");
            string unit = Console.ReadLine();
            
            double converted;

            switch(unit)
            {
                case "C":
                    converted = temperature * 1.8 + 32;
                    Console.WriteLine($"{temperature:F2} C = {converted:F2} F");
                    Console.WriteLine($"Absolute value: {Math.Abs(converted):F2}");
                    break;
                case "F":
                    converted = (temperature - 32) / 1.8;
                    Console.WriteLine($"{temperature:F2} F = {converted:F2} C");
                    Console.WriteLine($"Absolute value: {Math.Abs(converted):F2}");
                    break;
                default:
                    Console.WriteLine("Invalid unit.");
                    break;
            }
    }
}
}
