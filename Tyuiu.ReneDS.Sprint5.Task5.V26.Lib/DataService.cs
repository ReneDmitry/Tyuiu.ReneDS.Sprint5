using System.Globalization;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReneDS.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] values = text.Split(
                new[] { ' ', '\r', '\n', '\t', ';' },
                StringSplitOptions.RemoveEmptyEntries);

            double positiveSum = 0;
            double negativeSum = 0;

            foreach (string value in values)
            {
                double number = double.Parse(
                    value.Replace(',', '.'),
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture);

                if (number == Math.Truncate(number))
                {
                    continue;
                }

                if (number > 0)
                {
                    positiveSum += number;
                }
                else
                {
                    negativeSum += number;
                }
            }

            return Math.Round(positiveSum - negativeSum, 3);
        }
    }
}
