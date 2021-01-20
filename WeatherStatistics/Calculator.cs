using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStatistics
{
    class Calculator
    {
        /// <summary>
        /// Get the average value from a collection of double.
        /// </summary>
        public static double Average(List<double> numbers)
        {
            return Average(numbers.ToArray());
        }

        /// <summary>
        /// Get the average value from a collection of double.
        /// </summary>
        public static double Average(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        /// <summary>
        /// Get the highest number in a collection.
        /// </summary>
        public static double High(List<double> numbers)
        {
            return High(numbers.ToArray());
        }

        /// <summary>
        /// Get the highest number in a collection.
        /// </summary>
        public static double High(double[] numbers)
        {
            double high = Double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > high)
                    high = numbers[i];
            }

            return high;
        }

        /// <summary>
        /// Get the lowest number in a collection.
        /// </summary>
        public static double Low(List<double> numbers)
        {
            return Low(numbers.ToArray());
        }

        /// <summary>
        /// Get the lowest number in a collection.
        /// </summary>
        public static double Low(double[] numbers)
        {
            double low = Double.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < low)
                    low = numbers[i];
            }

            return low;
        }
    }
}
