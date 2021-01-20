using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace WeatherStatistics
{
    class Program
    {
        private static List<double> measurements = new List<double>();
        
        static void Main(string[] args)
        {          
            // If no provited args from application launch, ask for them now.
            if (args.Length == 0)
            {
                Console.WriteLine("Enter measurements:");
                args = new Regex("[ ]{2,}", RegexOptions.None).Replace(Console.ReadLine(), " ").Split(' ');
            }

            // Try to convert each argument to double and add it to measurements list.
            foreach (var arg in args)
            {
                if (Double.TryParse(arg.Replace('.', ','), out double measurement))
                    measurements.Add(measurement);
            }

            // Print added measurements.
            Console.WriteLine("\nADDED MEASUREMENTS:");
            foreach (var measurement in measurements)
            {
                Console.WriteLine(measurement);
            }

            // Print summary.
            Console.WriteLine("\nSUMMARY:\n" +
                "Average: " + Calculator.Average(measurements) + "\n" +
                "High: " + Calculator.High(measurements) + "\n" +
                "Low: " + Calculator.Low(measurements));
        }
    }
}
