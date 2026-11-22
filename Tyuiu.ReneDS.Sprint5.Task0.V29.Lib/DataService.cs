using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReneDS.Sprint5.Task0.V29.Lib
{
    public class DataService : ISprint5Task0V29
    {
        public string SaveToFileTextData(int x)
        {
            string directory = @"C:\Users\Пользователь\source\repos\Tyuiu.ReneDS.Sprint5\Tyuiu.ReneDS.Sprint5.Task0.V29\bin\Debug";
            Directory.CreateDirectory(directory);

            string path = Path.Combine(directory, "OutPutFileTask0.txt");

            double res = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            res = Math.Round(res, 3);

            File.WriteAllText(path, res.ToString("F3"));

            return path;
        }
    }
}
