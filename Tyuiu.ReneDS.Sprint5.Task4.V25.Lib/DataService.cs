using System.Globalization;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReneDS.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();
            double x = double.Parse(strX.Replace(',', '.'), CultureInfo.InvariantCulture);

            double res = Math.Round((Math.Pow(x, 4) + Math.Cos(x)) * Math.Sin(x), 3);
            return res;

        }

    }
}
